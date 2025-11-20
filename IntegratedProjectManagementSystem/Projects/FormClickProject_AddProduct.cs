using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormClickProject_AddProduct : Form
    {
        private int _projectId;

        public FormClickProject_AddProduct(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
            LoadAvailableProducts();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvProductList.AutoGenerateColumns = false;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProductList.Columns.Clear();
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductId",
                DataPropertyName = "ProductId",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                DataPropertyName = "ProductName",
                HeaderText = "Product Name",
                Width = 150
            });
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Description",
                DataPropertyName = "Description",
                HeaderText = "Description",
                Width = 200
            });
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Category",
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 100
            });
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Dimension",
                DataPropertyName = "Dimension",
                HeaderText = "Dimension",
                Width = 100
            });
            dgvProductList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SalePrice",
                DataPropertyName = "SalePrice",
                HeaderText = "Price",
                Width = 80
            });
        }

        private void LoadAvailableProducts()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT ProductId, ProductName, Description, Category, Dimension, SalePrice
                        FROM Products 
                        WHERE IsActive = 1 
                        AND ProductId NOT IN (
                            SELECT ProductId FROM ProjectProducts WHERE ProjectId = @ProjectId
                        )
                        ORDER BY ProductName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProductList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int productId = Convert.ToInt32(dgvProductList.SelectedRows[0].Cells["ProductId"].Value);
                decimal productPrice = Convert.ToDecimal(dgvProductList.SelectedRows[0].Cells["SalePrice"].Value);
                decimal itemTotal = productPrice * quantity;

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Start transaction to ensure both operations succeed
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insert into ProjectProducts
                            string insertQuery = @"
                        INSERT INTO ProjectProducts (ProjectId, ProductId, Quantity)
                        VALUES (@ProjectId, @ProductId, @Quantity)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ProjectId", _projectId);
                                cmd.Parameters.AddWithValue("@ProductId", productId);
                                cmd.Parameters.AddWithValue("@Quantity", quantity);
                                cmd.ExecuteNonQuery();
                            }

                            // 2. Update Project TotalPrice
                            string updateQuery = @"
                        UPDATE Projects 
                        SET TotalPrice = ISNULL(TotalPrice, 0) + @ItemTotal
                        WHERE ProjectId = @ProjectId";

                            using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ItemTotal", itemTotal);
                                cmd.Parameters.AddWithValue("@ProjectId", _projectId);
                                cmd.ExecuteNonQuery();
                            }

                            // Commit transaction
                            transaction.Commit();

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product to project: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}