using IntegratedProjectManagementSystem.Resources;
using IntegratedProjectManagementSystem.Services;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormClickProject : Form
    {
        private int _projectId;
        private ProjectService _projectService;

        public FormClickProject(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
            _projectService = new ProjectService();
            LoadProjectDetails();
            LoadProjectProducts();
            //LoadProjectEmployees
        }

        private void LoadProjectDetails()
        {
            try
            {
                var project = _projectService.GetProjectById(_projectId);
                if (project != null)
                {
                    // Display project details in your form controls
                    this.Text = $"Project: {project.ProjectName} - ID: {project.ProjectId}";

                    // Example: Display in labels or other controls
                    lblProjectName.Text = project.ProjectName;
                    lblClientName.Text = project.ClientName;
                    lblStatus.Text = project.Status;
                    // ... populate other controls as needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            try
            {
                // Open FormCreateProject in edit mode
                FormCreateProject editForm = new FormCreateProject(_projectId);
                editForm.ShowDialog();

                // Refresh project details after editing
                if (editForm.DialogResult == DialogResult.OK)
                {
                    LoadProjectDetails();
                    // Optional: Refresh parent form if needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening edit form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //////////////////////////////////////////// PROJECT PRODUCTS ////////////////////////////////////////////

        // DATA GRID VIEW LOAD PROJECT PRODUCTS

        private void LoadProjectProducts()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT pp.ProjectProductId, pp.Quantity, 
                       p.ProductName, p.Description, p.Category, p.Dimension, p.SalePrice,
                       (pp.Quantity * p.SalePrice) as TotalPrice
                FROM ProjectProducts pp
                INNER JOIN Products p ON pp.ProductId = p.ProductId
                WHERE pp.ProjectId = @ProjectId
                ORDER BY p.ProductName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProjectProductList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            FormClickProject_AddProduct addProductForm = new FormClickProject_AddProduct(_projectId);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                LoadProjectProducts(); 
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProjectProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove this product from the project?",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int projectProductId = Convert.ToInt32(dgvProjectProductList.SelectedRows[0].Cells["ProjectProductId"].Value);

                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM ProjectProducts WHERE ProjectProductId = @ProjectProductId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProjectProductId", projectProductId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadProjectProducts(); // Refresh the list
                    MessageBox.Show("Product removed successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing product: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        //////////////////////////////////////////// PROJECT EMPLOYEES ////////////////////////////////////////////
    }
}