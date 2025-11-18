using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Inventory
{
    public partial class FormCreateMaterial : Form
    {
        public FormCreateMaterial()
        {
            InitializeComponent();
            LoadMaterials();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Configure DataGridView appearance
            dgvMaterials.AutoGenerateColumns = false;
            dgvMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterials.ReadOnly = true;

            // Add columns manually for better control
            dgvMaterials.Columns.Clear();
            dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaterialId",
                DataPropertyName = "MaterialId",
                HeaderText = "ID",
                Width = 50
            });
            dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaterialName",
                DataPropertyName = "MaterialName",
                HeaderText = "Material Name",
                Width = 150
            });
            dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Category",
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 100
            });
            dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CurrentStock",
                DataPropertyName = "CurrentStock",
                HeaderText = "Stock",
                Width = 80
            });
            dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UnitOfMeasure",
                DataPropertyName = "UnitOfMeasure",
                HeaderText = "Unit",
                Width = 70
            });
            dgvMaterials.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UnitCost",
                DataPropertyName = "UnitCost",
                HeaderText = "Unit Cost",
                Width = 90
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

                    dgvMaterials.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading materials: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtMaterialName.Text))
                {
                    MessageBox.Show("Material name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbCategory.Text))
                {
                    MessageBox.Show("Category is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate numeric fields
                if (!decimal.TryParse(txtCurrentStock.Text, out decimal currentStock))
                {
                    MessageBox.Show("Please enter a valid current stock amount.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtUnitCost.Text, out decimal unitCost))
                {
                    MessageBox.Show("Please enter a valid unit cost.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand command;

                    if (string.IsNullOrEmpty(txtMaterialID.Text)) // New material
                    {
                        command = new SqlCommand(
                            "INSERT INTO Materials (MaterialName, Category, CurrentStock, UnitOfMeasure, UnitCost) " +
                            "VALUES (@name, @category, @stock, @unit, @cost)", conn);
                    }
                    else // Existing material
                    {
                        command = new SqlCommand(
                            "UPDATE Materials SET MaterialName=@name, Category=@category, " +
                            "CurrentStock=@stock, UnitOfMeasure=@unit, UnitCost=@cost " +
                            "WHERE MaterialId=@id", conn);
                        command.Parameters.AddWithValue("@id", int.Parse(txtMaterialID.Text));
                    }

                    command.Parameters.AddWithValue("@name", txtMaterialName.Text.Trim());
                    command.Parameters.AddWithValue("@category", cmbCategory.Text);
                    command.Parameters.AddWithValue("@stock", currentStock);
                    command.Parameters.AddWithValue("@unit", txtUnitOfMeasure.Text.Trim());
                    command.Parameters.AddWithValue("@cost", unitCost);

                    command.ExecuteNonQuery();
                }

                LoadMaterials();
                ClearFields();
                MessageBox.Show("Material saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving material: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtMaterialID.Clear();
            txtMaterialName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtCurrentStock.Clear();
            txtUnitOfMeasure.Clear();
            txtUnitCost.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMaterials();
        }

        private void dgvMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMaterials.Rows[e.RowIndex];

                // Load values into form fields
                txtMaterialID.Text = row.Cells["MaterialId"].Value.ToString();
                txtMaterialName.Text = row.Cells["MaterialName"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value?.ToString();
                txtCurrentStock.Text = row.Cells["CurrentStock"].Value?.ToString();
                txtUnitOfMeasure.Text = row.Cells["UnitOfMeasure"].Value?.ToString();
                txtUnitCost.Text = row.Cells["UnitCost"].Value?.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Materials WHERE IsActive = 1";
                    List<string> conditions = new List<string>();

                    // Apply category filter
                    if (!string.IsNullOrEmpty(cmbFilter.Text))
                    {
                        conditions.Add("Category = @Category");
                    }

                    // Apply search filter
                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        conditions.Add("MaterialName LIKE @Search");
                    }

                    if (conditions.Count > 0)
                    {
                        query += " AND " + string.Join(" AND ", conditions);
                    }

                    query += " ORDER BY MaterialName";

                    SqlCommand command = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(cmbFilter.Text))
                    {
                        command.Parameters.AddWithValue("@Category", cmbFilter.Text);
                    }

                    if (!string.IsNullOrEmpty(txtSearch.Text))
                    {
                        command.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMaterials.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering materials: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}