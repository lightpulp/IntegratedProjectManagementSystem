using IntegratedProjectManagementSystem.Dashboard;
using IntegratedProjectManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace IntegratedProjectManagementSystem.Inventory
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
            LoadProducts();
            cmbCategory.Items.AddRange(new string[] { 
                "Indoor", 
                "Outdoor", 
                "Chair", 
                "Table", 
                "Office" });
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormDashboard>(this);
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormInventory>(this);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            txtSalePrice.Clear();
            cbActive.Checked = false;
            txtCustomDimension.Clear();
            txtCustomMaterial.Clear();
            txtSpecialInstruction.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                SqlCommand command;

                if (string.IsNullOrEmpty(txtProductID.Text)) // New product
                {
                    command = new SqlCommand(
                        "INSERT INTO Products (ProductName, Category, Description, SalePrice, IsActive, CustomDimensions, CustomMaterials, SpecialInstructions) " +
                        "VALUES (@name, @category, @description, @price, @active, @dimensions, @materials, @instructions)", connection);
                }
                else // Existing product
                {
                    command = new SqlCommand(
                        "UPDATE Products SET ProductName=@name, Category=@category, Description=@description, SalePrice=@price, IsActive=@active, " +
                        "CustomDimensions=@dimensions, CustomMaterials=@materials, SpecialInstructions=@instructions WHERE ProductID=@id", connection);
                    command.Parameters.AddWithValue("@id", int.Parse(txtProductID.Text));
                }

                command.Parameters.AddWithValue("@name", txtProductName.Text);
                command.Parameters.AddWithValue("@category", cmbCategory.Text);
                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@price", decimal.Parse(txtSalePrice.Text));
                command.Parameters.AddWithValue("@active", cbActive.Checked);
                command.Parameters.AddWithValue("@dimensions", txtCustomDimension.Text);
                command.Parameters.AddWithValue("@materials", txtCustomMaterial.Text);
                command.Parameters.AddWithValue("@instructions", txtSpecialInstruction.Text);

                command.ExecuteNonQuery();
            }

            LoadProducts();
            ClearFields();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure it's not the header row
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                // Load values into form fields
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtSalePrice.Text = row.Cells["SalePrice"].Value.ToString();
                cbActive.Checked = (bool)row.Cells["IsActive"].Value;
                txtCustomDimension.Text = row.Cells["CustomDimensions"].Value.ToString();
                txtCustomMaterial.Text = row.Cells["CustomMaterials"].Value.ToString();
                txtSpecialInstruction.Text = row.Cells["SpecialInstructions"].Value.ToString();
            }
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
