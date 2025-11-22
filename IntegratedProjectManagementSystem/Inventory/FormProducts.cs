using IntegratedProjectManagementSystem.Dashboard;
using IntegratedProjectManagementSystem.Projects;
using IntegratedProjectManagementSystem.Resources;
using IntegratedProjectManagementSystem.Services;
using IntegratedProjectManagementSystem.Staff;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Inventory
{
    public partial class FormProducts : Form
    {
        private ProductService _productService;

        public FormProducts()
        {
            InitializeComponent();
            _productService = new ProductService();
            LoadGridView();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void btnDisplayProducts_Click(object sender, EventArgs e)
        {
            LoadProductsCardView();
        }


        /////// CARD VIEW ///////
        private void LoadProductsCardView()
        {
            try
            {
                // Clear existing cards
                pnlProductsCardview.Controls.Clear();

                string category = cardviewcmbbxFilter.SelectedItem?.ToString() ?? "";
                string searchTerm = cardviewtxtSearch.Text.Trim();

                var products = _productService.GetFilteredProducts(category, searchTerm);

                if (products.Count == 0)
                {
                    Label noProductsLabel = new Label
                    {
                        Text = "No products found. Create your first product!",
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10),
                        ForeColor = Color.Gray,
                        Location = new Point(20, 20)
                    };
                    pnlProductsCardview.Controls.Add(noProductsLabel);
                    return;
                }

                int xPosition = 20;
                int yPosition = 20;
                int cardWidth = 220;
                int cardHeight = 300;
                int horizontalSpacing = 30;
                int verticalSpacing = 30;

                foreach (var product in products)
                {
                    // Create product card panel
                    Panel productCard = CreateProductCard(product, xPosition, yPosition, cardWidth, cardHeight);
                    pnlProductsCardview.Controls.Add(productCard);

                    // Calculate next card position
                    xPosition += cardWidth + horizontalSpacing;

                    // Move to next row if cards exceed panel width
                    if (xPosition + cardWidth > pnlProductsCardview.Width - 20)
                    {
                        xPosition = 20;
                        yPosition += cardHeight + verticalSpacing;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateProductCard(ProductService.Product product, int x, int y, int width, int height)
        {
            Panel card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(width, height),
                Location = new Point(x, y),
                Tag = product.ProductId, // Store product ID for click event
                Cursor = Cursors.Hand
            };

            // Product Image
            PictureBox picProduct = new PictureBox
            {
                Size = new Size(width - 20, 120),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray
            };

            if (product.ProductImage != null && product.ProductImage.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(product.ProductImage))
                {
                    picProduct.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Default placeholder image or text
                picProduct.Image = CreatePlaceholderImage(width - 20, 120, "No Image");
            }

            // Product Name
            Label lblName = new Label
            {
                Text = product.ProductName,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 20, 25),
                Location = new Point(10, 140),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Description (truncated)
            string description = string.IsNullOrEmpty(product.Description) ?
                "No description" :
                (product.Description.Length > 60 ?
                 product.Description.Substring(0, 60) + "..." :
                 product.Description);

            Label lblDescription = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9),
                AutoSize = false,
                Size = new Size(width - 20, 40),
                Location = new Point(10, 170),
                ForeColor = Color.Gray
            };

            // Dimension
            Label lblDimension = new Label
            {
                Text = $"Dimension: {product.Dimension}",
                Font = new Font("Segoe UI", 9),
                AutoSize = false,
                Size = new Size(width - 20, 20),
                Location = new Point(10, 215),
                ForeColor = Color.DarkBlue
            };

            // Price
            Label lblPrice = new Label
            {
                Text = $"Price: ₱{product.SalePrice:N2}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 20, 25),
                Location = new Point(10, 240),
                ForeColor = Color.Green,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Status indicator
            Label lblStatus = new Label
            {
                Text = product.IsActive ? "Active" : "Inactive",
                Font = new Font("Segoe UI", 8),
                AutoSize = true,
                Location = new Point(width - 60, height - 25),
                ForeColor = product.IsActive ? Color.Green : Color.Red
            };

            // Add all controls to card
            card.Controls.Add(picProduct);
            card.Controls.Add(lblName);
            card.Controls.Add(lblDescription);
            card.Controls.Add(lblDimension);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblStatus);

            // Add click event to open edit form
            card.Click += (sender, e) => OpenProductForEdit(product.ProductId);

            // Make all child controls clickable too
            foreach (Control control in card.Controls)
            {
                control.Click += (sender, e) => OpenProductForEdit(product.ProductId);
                control.Cursor = Cursors.Hand;
            }

            return card;
        }

        private Image CreatePlaceholderImage(int width, int height, string text)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 10))
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(text, font, Brushes.DarkGray, new Rectangle(0, 0, width, height), sf);
                }
            }
            return bmp;
        }

        private void OpenProductForEdit(int productId)
        {
            try
            {
                FormCreateProduct editForm = new FormCreateProduct(productId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the product display after editing
                    LoadProductsCardView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /////// GRID VIEW ///////
        private void LoadGridView()
        {
            try
            {
                string category = gridviewcmbbxFilter.SelectedItem?.ToString() ?? "";
                string searchTerm = gridviewtxtSearch.Text.Trim();

                var products = _productService.GetFilteredProducts(category, searchTerm);

                // Convert to DataTable for DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("ProductId", typeof(int));
                dt.Columns.Add("ProductName", typeof(string));
                dt.Columns.Add("Category", typeof(string));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Dimension", typeof(string));
                dt.Columns.Add("SalePrice", typeof(decimal));
                dt.Columns.Add("IsActive", typeof(bool));

                foreach (var product in products)
                {
                    dt.Rows.Add(
                        product.ProductId,
                        product.ProductName,
                        product.Category,
                        product.Description,
                        product.Dimension,
                        product.SalePrice,
                        product.IsActive
                    );
                }

                dgvProducts.DataSource = dt;

                // Format columns
                dgvProducts.Columns["SalePrice"].DefaultCellStyle.Format = "N2";
                dgvProducts.Columns["SalePrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products grid: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            FormCreateProduct createForm = new FormCreateProduct();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the product display after creating new product
                LoadProductsCardView();
            }
        }





        /// NAVIGATION ///
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormDashboard>(this);
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormInventory>(this);
        }
        private void btnProjects_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormProject>(this);

        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormStaff>(this);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            HelperNavigation.ReturnToLogin(this);
        }


        ///// BUTTONS /////

        private void gridviewbtnRefreshDisplay_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void gridviewcmbbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void cardviewcmbbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsCardView();
        }
        private void cardviewtxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProductsCardView();
        }

        private void gridviewtxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add a delay to prevent too many database calls
            LoadGridView();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductId"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();

            // Check if product is used in any projects
            if (IsProductUsedInProjects(productId))
            {
                MessageBox.Show($"Cannot remove '{productName}'. It is currently used in one or more projects.",
                    "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to remove '{productName}'?",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Use soft delete (set IsActive to false)
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "UPDATE Products SET IsActive = 0 WHERE ProductId = @ProductId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductId", productId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product removed successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridView(); // Refresh the grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing product: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsProductUsedInProjects(int productId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM ProjectProducts WHERE ProductId = @ProductId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking product usage: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Return true to be safe and prevent deletion
            }
        }


        private void gridviewbtnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductId"].Value);

            try
            {
                FormCreateProduct editForm = new FormCreateProduct(productId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadGridView(); // Refresh the grid after editing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening product editor: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}