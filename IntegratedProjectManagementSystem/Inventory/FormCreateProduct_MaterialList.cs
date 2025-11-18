using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Inventory
{
    public partial class FormCreateProduct_MaterialList : Form
    {
        public int SelectedMaterialId { get; private set; }
        public string SelectedMaterialName { get; private set; }
        public decimal QuantityRequired { get; private set; }

        public FormCreateProduct_MaterialList()
        {
            InitializeComponent();
            LoadMaterials();
            SetupMaterialsGrid();
        }

        private void SetupMaterialsGrid()
        {
            dgvMaterialList.AutoGenerateColumns = false;
            dgvMaterialList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMaterialList.Columns.Clear();
            dgvMaterialList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaterialId",
                DataPropertyName = "MaterialId",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });
            dgvMaterialList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaterialName",
                DataPropertyName = "MaterialName",
                HeaderText = "Material Name",
                Width = 150
            });
            dgvMaterialList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Category",
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 100
            });
            dgvMaterialList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CurrentStock",
                DataPropertyName = "CurrentStock",
                HeaderText = "Available Stock",
                Width = 80
            });
            dgvMaterialList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UnitOfMeasure",
                DataPropertyName = "UnitOfMeasure",
                HeaderText = "Unit",
                Width = 70
            });
            dgvMaterialList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UnitCost",
                DataPropertyName = "UnitCost",
                HeaderText = "Unit Cost",
                Width = 80
            });
        }

        private void LoadMaterials()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Materials WHERE IsActive = 1 ORDER BY MaterialName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMaterialList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading materials: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaterialList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaterialList.Rows[e.RowIndex];
                SelectedMaterialId = Convert.ToInt32(row.Cells["MaterialId"].Value);
                SelectedMaterialName = row.Cells["MaterialName"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SelectedMaterialId == 0)
            {
                MessageBox.Show("Please select a material first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if quantity exceeds available stock
            decimal availableStock = GetAvailableStock(SelectedMaterialId);
            if (quantity > availableStock)
            {
                MessageBox.Show($"Quantity exceeds available stock. Only {availableStock} units available.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            QuantityRequired = quantity;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private decimal GetAvailableStock(int materialId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT CurrentStock FROM Materials WHERE MaterialId = @MaterialId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaterialId", materialId);
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}