using IntegratedProjectManagementSystem.Services;
using System;
using System.Collections.Generic;
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
        }

        private void btnDisplayProducts_Click(object sender, EventArgs e)
        {
            LoadProductsCardView();
        }

        private void LoadProductsCardView()
        {
            try
            {
                // Clear existing cards
                pnlProductsCardview.Controls.Clear();

                var products = _productService.GetAllProducts();

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

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            FormCreateProduct createForm = new FormCreateProduct();
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the product display after creating new product
                LoadProductsCardView();
            }
        }
    }
}