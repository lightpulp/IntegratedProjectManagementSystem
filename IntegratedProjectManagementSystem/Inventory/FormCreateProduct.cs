using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Inventory
{
    public partial class FormCreateProduct : Form
    {
        private int _currentProductId = 0;
        private bool _isEditMode = false;

        public FormCreateProduct()
        {
            InitializeComponent();
            LoadCategories();
            SetupMaterialsGrid();

            btnDelete.Visible = false; // Hide delete in create mode
            btnDelete.Enabled = false;
        }

        public FormCreateProduct(int productId) : this()
        {
            _currentProductId = productId;
            _isEditMode = true;
            this.Text = "Edit Product";
            btnSave.Text = "Update Product";
            btnDelete.Visible = true; // Show delete in edit mode
            btnDelete.Enabled = true;
            LoadProductData();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.AddRange(new string[] {
                "Chair", "Table", "Cabinet", "Sofa", "Bed",
                "Desk", "Shelf", "Dining Set", "Office", "Outdoor"
            });
        }

        private void SetupMaterialsGrid()
        {
            dgvMaterialsUsed.AutoGenerateColumns = false;
            dgvMaterialsUsed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMaterialsUsed.Columns.Clear();
            dgvMaterialsUsed.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaterialName",
                DataPropertyName = "MaterialName",
                HeaderText = "Material Name",
                Width = 150
            });
            dgvMaterialsUsed.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Category",
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 100
            });
            dgvMaterialsUsed.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "QuantityRequired",
                DataPropertyName = "QuantityRequired",
                HeaderText = "Qty Required",
                Width = 80
            });
            dgvMaterialsUsed.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "UnitOfMeasure",
                DataPropertyName = "UnitOfMeasure",
                HeaderText = "Unit",
                Width = 70
            });
        }

        private void LoadProductData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Load product details
                    string productQuery = "SELECT * FROM Products WHERE ProductId = @ProductId";
                    using (SqlCommand cmd = new SqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", _currentProductId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProductID.Text = reader["ProductId"].ToString();
                                txtProductName.Text = reader["ProductName"].ToString();
                                txtDescription.Text = reader["Description"].ToString();
                                cmbCategory.Text = reader["Category"].ToString();
                                txtDimension.Text = reader["Dimension"].ToString();
                                txtSalePrice.Text = reader["SalePrice"].ToString();
                                cbActive.Checked = (bool)reader["IsActive"];

                                // Load image if exists
                                if (reader["ProductImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["ProductImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        // Create a clone of the image to detach it from the stream
                                        using (Image tmp = Image.FromStream(ms))
                                        {
                                            pboxImage.Image = new Bitmap(tmp);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Load materials used
                    LoadProductMaterials();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductMaterials()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT pm.ProductMaterialId, pm.QuantityRequired, 
                               m.MaterialName, m.Category, m.UnitOfMeasure
                        FROM ProductMaterials pm
                        INNER JOIN Materials m ON pm.MaterialId = m.MaterialId
                        WHERE pm.ProductId = @ProductId";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProductId", _currentProductId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvMaterialsUsed.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading materials: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load image via stream and clone to avoid locking the file
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (Image tmp = Image.FromStream(fs))
                        {
                            pboxImage.Image = new Bitmap(tmp);
                        }
                    }
                }
            }
        }

        private void btnChooseMaterials_Click(object sender, EventArgs e)
        {
            FormCreateProduct_MaterialList materialForm = new FormCreateProduct_MaterialList();
            if (materialForm.ShowDialog() == DialogResult.OK && _currentProductId > 0)
            {
                // Save the material to ProductMaterials table
                SaveProductMaterial(_currentProductId, materialForm.SelectedMaterialId, materialForm.QuantityRequired);
                LoadProductMaterials(); // Refresh the materials grid
            }
            else if (_currentProductId == 0)
            {
                MessageBox.Show("Please save the product first before adding materials.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveProductMaterial(int productId, int materialId, decimal quantity)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                INSERT INTO ProductMaterials (ProductId, MaterialId, QuantityRequired)
                VALUES (@ProductId, @MaterialId, @Quantity)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@MaterialId", materialId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving material: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    MessageBox.Show("Product name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtSalePrice.Text, out decimal salePrice))
                {
                    MessageBox.Show("Please enter a valid sale price.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save product
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlCommand command;

                    if (_isEditMode)
                    {
                        command = new SqlCommand(
                            "UPDATE Products SET ProductName=@name, Description=@desc, Category=@category, " +
                            "Dimension=@dimension, SalePrice=@price, IsActive=@active, ProductImage=@image " +
                            "WHERE ProductId=@id", conn);
                        command.Parameters.AddWithValue("@id", _currentProductId);
                    }
                    else
                    {
                        command = new SqlCommand(
                            "INSERT INTO Products (ProductName, Description, Category, Dimension, SalePrice, IsActive, ProductImage) " +
                            "VALUES (@name, @desc, @category, @dimension, @price, @active, @image); SELECT SCOPE_IDENTITY();", conn);
                    }

                    command.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                    command.Parameters.AddWithValue("@desc", (object)txtDescription.Text ?? DBNull.Value);
                    command.Parameters.AddWithValue("@category", (object)cmbCategory.Text ?? DBNull.Value);
                    command.Parameters.AddWithValue("@dimension", (object)txtDimension.Text ?? DBNull.Value);
                    command.Parameters.AddWithValue("@price", salePrice);
                    command.Parameters.AddWithValue("@active", cbActive.Checked);

                    // Clone the image before saving to avoid GDI+ errors
                    var imageBytes = (object)ImageToByteArray(pboxImage.Image) ?? DBNull.Value;
                    command.Parameters.AddWithValue("@image", imageBytes);

                    if (_isEditMode)
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _currentProductId = Convert.ToInt32(command.ExecuteScalar());
                        MessageBox.Show("Product created successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            // Clone image into a bitmap to detach any underlying stream or file lock
            using (Bitmap bmp = new Bitmap(image))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentProductId == 0 || !_isEditMode)
            {
                MessageBox.Show("Cannot delete a product that hasn't been saved.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this product? This action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteProduct(_currentProductId);
                    MessageBox.Show("Product deleted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteProduct(int productId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // First check if product is used in any projects
                string checkQuery = "SELECT COUNT(*) FROM ProjectProducts WHERE ProductId = @ProductId";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ProductId", productId);
                    int usageCount = (int)checkCmd.ExecuteScalar();

                    if (usageCount > 0)
                    {
                        throw new Exception("Cannot delete product. It is currently used in one or more projects.");
                    }
                }

                // Delete from ProductMaterials first (due to foreign key constraint)
                string deleteMaterialsQuery = "DELETE FROM ProductMaterials WHERE ProductId = @ProductId";
                using (SqlCommand materialsCmd = new SqlCommand(deleteMaterialsQuery, conn))
                {
                    materialsCmd.Parameters.AddWithValue("@ProductId", productId);
                    materialsCmd.ExecuteNonQuery();
                }

                // Then delete the product
                string deleteProductQuery = "DELETE FROM Products WHERE ProductId = @ProductId";
                using (SqlCommand productCmd = new SqlCommand(deleteProductQuery, conn))
                {
                    productCmd.Parameters.AddWithValue("@ProductId", productId);
                    productCmd.ExecuteNonQuery();
                }
            }
        }
    }
}