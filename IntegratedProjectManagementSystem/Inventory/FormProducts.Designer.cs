namespace IntegratedProjectManagementSystem.Inventory
{
    partial class FormProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navbarLeft = new MenuStrip();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            btnCreateProduct = new Button();
            tabControl1 = new TabControl();
            tabCardView = new TabPage();
            pnlProductsCardview = new Panel();
            tabGridView = new TabPage();
            dgvProducts = new DataGridView();
            btnDisplayProducts = new Button();
            navbarLeft.SuspendLayout();
            tabControl1.SuspendLayout();
            tabCardView.SuspendLayout();
            tabGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // navbarLeft
            // 
            navbarLeft.AutoSize = false;
            navbarLeft.BackColor = SystemColors.ActiveCaption;
            navbarLeft.Dock = DockStyle.Left;
            navbarLeft.Items.AddRange(new ToolStripItem[] { btnDashboard, btnProjects, btnInventory, btnStaff, btnLogout });
            navbarLeft.Location = new Point(0, 0);
            navbarLeft.Name = "navbarLeft";
            navbarLeft.Padding = new Padding(7, 2, 0, 2);
            navbarLeft.Size = new Size(181, 561);
            navbarLeft.TabIndex = 16;
            navbarLeft.Text = "menuStrip1";
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = false;
            btnDashboard.BackColor = Color.FromArgb(128, 128, 255);
            btnDashboard.Margin = new Padding(10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(148, 40);
            btnDashboard.Text = "DASHBOARD";
            // 
            // btnProjects
            // 
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(173, 19);
            btnProjects.Text = "Projects";
            // 
            // btnInventory
            // 
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(173, 19);
            btnInventory.Text = "Inventory";
            // 
            // btnStaff
            // 
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(173, 19);
            btnStaff.Text = "Staff";
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 19);
            btnLogout.Text = "Logout";
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(889, 12);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(271, 23);
            btnCreateProduct.TabIndex = 20;
            btnCreateProduct.Text = "Create New Product";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCardView);
            tabControl1.Controls.Add(tabGridView);
            tabControl1.Location = new Point(206, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(954, 307);
            tabControl1.TabIndex = 21;
            // 
            // tabCardView
            // 
            tabCardView.Controls.Add(btnDisplayProducts);
            tabCardView.Controls.Add(pnlProductsCardview);
            tabCardView.Location = new Point(4, 24);
            tabCardView.Name = "tabCardView";
            tabCardView.Padding = new Padding(3);
            tabCardView.Size = new Size(946, 279);
            tabCardView.TabIndex = 0;
            tabCardView.Text = "Card View";
            tabCardView.UseVisualStyleBackColor = true;
            // 
            // pnlProductsCardview
            // 
            pnlProductsCardview.AutoScroll = true;
            pnlProductsCardview.Location = new Point(6, 53);
            pnlProductsCardview.Name = "pnlProductsCardview";
            pnlProductsCardview.Size = new Size(934, 220);
            pnlProductsCardview.TabIndex = 0;
            // 
            // tabGridView
            // 
            tabGridView.Controls.Add(dgvProducts);
            tabGridView.Location = new Point(4, 24);
            tabGridView.Name = "tabGridView";
            tabGridView.Padding = new Padding(3);
            tabGridView.Size = new Size(946, 279);
            tabGridView.TabIndex = 1;
            tabGridView.Text = "Grid View";
            tabGridView.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(266, 26);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(653, 216);
            dgvProducts.TabIndex = 0;
            // 
            // btnDisplayProducts
            // 
            btnDisplayProducts.Location = new Point(669, 6);
            btnDisplayProducts.Name = "btnDisplayProducts";
            btnDisplayProducts.Size = new Size(271, 23);
            btnDisplayProducts.TabIndex = 22;
            btnDisplayProducts.Text = "display";
            btnDisplayProducts.UseVisualStyleBackColor = true;
            btnDisplayProducts.Click += btnDisplayProducts_Click;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(tabControl1);
            Controls.Add(btnCreateProduct);
            Controls.Add(navbarLeft);
            Name = "FormProducts";
            Text = "FormProducts";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabCardView.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip navbarLeft;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
        private Button btnCreateProduct;
        private TabControl tabControl1;
        private TabPage tabCardView;
        private TabPage tabGridView;
        private DataGridView dgvProducts;
        private Panel pnlProductsCardview;
        private Button btnDisplayProducts;
    }
}