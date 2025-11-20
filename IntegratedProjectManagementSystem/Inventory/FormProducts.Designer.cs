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
            tabGridView = new TabPage();
            gridviewbtnEditProduct = new Button();
            label2 = new Label();
            gridviewcmbbxFilter = new ComboBox();
            label1 = new Label();
            gridviewtxtSearch = new TextBox();
            gridviewbtnRefreshDisplay = new Button();
            btnRemoveProduct = new Button();
            dgvProducts = new DataGridView();
            tabCardView = new TabPage();
            label3 = new Label();
            cardviewcmbbxFilter = new ComboBox();
            label4 = new Label();
            cardviewtxtSearch = new TextBox();
            btnDisplayProducts = new Button();
            pnlProductsCardview = new Panel();
            navbarLeft.SuspendLayout();
            tabControl1.SuspendLayout();
            tabGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabCardView.SuspendLayout();
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProjects
            // 
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(173, 19);
            btnProjects.Text = "Projects";
            btnProjects.Click += btnProjects_Click;
            // 
            // btnInventory
            // 
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(173, 19);
            btnInventory.Text = "Inventory";
            btnInventory.Click += btnInventory_Click;
            // 
            // btnStaff
            // 
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(173, 19);
            btnStaff.Text = "Staff";
            btnStaff.Click += btnStaff_Click;
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 19);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateProduct.Location = new Point(885, 502);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(271, 47);
            btnCreateProduct.TabIndex = 20;
            btnCreateProduct.Text = "Create New Product";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabGridView);
            tabControl1.Controls.Add(tabCardView);
            tabControl1.Location = new Point(202, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(954, 484);
            tabControl1.TabIndex = 21;
            // 
            // tabGridView
            // 
            tabGridView.Controls.Add(gridviewbtnEditProduct);
            tabGridView.Controls.Add(label2);
            tabGridView.Controls.Add(gridviewcmbbxFilter);
            tabGridView.Controls.Add(label1);
            tabGridView.Controls.Add(gridviewtxtSearch);
            tabGridView.Controls.Add(gridviewbtnRefreshDisplay);
            tabGridView.Controls.Add(btnRemoveProduct);
            tabGridView.Controls.Add(dgvProducts);
            tabGridView.Location = new Point(4, 24);
            tabGridView.Name = "tabGridView";
            tabGridView.Padding = new Padding(3);
            tabGridView.Size = new Size(946, 456);
            tabGridView.TabIndex = 1;
            tabGridView.Text = "Grid View";
            tabGridView.UseVisualStyleBackColor = true;
            // 
            // gridviewbtnEditProduct
            // 
            gridviewbtnEditProduct.Font = new Font("Tahoma", 11.25F);
            gridviewbtnEditProduct.Location = new Point(626, 11);
            gridviewbtnEditProduct.Name = "gridviewbtnEditProduct";
            gridviewbtnEditProduct.Size = new Size(111, 42);
            gridviewbtnEditProduct.TabIndex = 7;
            gridviewbtnEditProduct.Text = "Edit Product";
            gridviewbtnEditProduct.UseVisualStyleBackColor = true;
            gridviewbtnEditProduct.Click += gridviewbtnEditProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 26);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 6;
            label2.Text = "Filter";
            // 
            // gridviewcmbbxFilter
            // 
            gridviewcmbbxFilter.Font = new Font("Tahoma", 11.25F);
            gridviewcmbbxFilter.FormattingEnabled = true;
            gridviewcmbbxFilter.Items.AddRange(new object[] { "Chair", "Table", "Cabinet", "Sofa", "Bed", "Desk", "Shelf", "Dining Set", "Office", "Outdoor" });
            gridviewcmbbxFilter.Location = new Point(333, 22);
            gridviewcmbbxFilter.Name = "gridviewcmbbxFilter";
            gridviewcmbbxFilter.Size = new Size(121, 26);
            gridviewcmbbxFilter.TabIndex = 5;
            gridviewcmbbxFilter.SelectedIndexChanged += gridviewcmbbxFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 4;
            label1.Text = "Search";
            // 
            // gridviewtxtSearch
            // 
            gridviewtxtSearch.Font = new Font("Tahoma", 11.25F);
            gridviewtxtSearch.Location = new Point(83, 22);
            gridviewtxtSearch.Name = "gridviewtxtSearch";
            gridviewtxtSearch.Size = new Size(188, 26);
            gridviewtxtSearch.TabIndex = 3;
            gridviewtxtSearch.TextChanged += gridviewtxtSearch_TextChanged;
            // 
            // gridviewbtnRefreshDisplay
            // 
            gridviewbtnRefreshDisplay.Font = new Font("Tahoma", 11.25F);
            gridviewbtnRefreshDisplay.Location = new Point(743, 11);
            gridviewbtnRefreshDisplay.Name = "gridviewbtnRefreshDisplay";
            gridviewbtnRefreshDisplay.Size = new Size(176, 42);
            gridviewbtnRefreshDisplay.TabIndex = 2;
            gridviewbtnRefreshDisplay.Text = "Refresh Display";
            gridviewbtnRefreshDisplay.UseVisualStyleBackColor = true;
            gridviewbtnRefreshDisplay.Click += gridviewbtnRefreshDisplay_Click;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Font = new Font("Tahoma", 11.25F);
            btnRemoveProduct.Location = new Point(493, 11);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(127, 42);
            btnRemoveProduct.TabIndex = 1;
            btnRemoveProduct.Text = "Remove Product";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(25, 59);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(894, 374);
            dgvProducts.TabIndex = 0;
            // 
            // tabCardView
            // 
            tabCardView.Controls.Add(label3);
            tabCardView.Controls.Add(cardviewcmbbxFilter);
            tabCardView.Controls.Add(label4);
            tabCardView.Controls.Add(cardviewtxtSearch);
            tabCardView.Controls.Add(btnDisplayProducts);
            tabCardView.Controls.Add(pnlProductsCardview);
            tabCardView.Location = new Point(4, 24);
            tabCardView.Name = "tabCardView";
            tabCardView.Padding = new Padding(3);
            tabCardView.Size = new Size(946, 456);
            tabCardView.TabIndex = 0;
            tabCardView.Text = "Card View";
            tabCardView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(335, 19);
            label3.Name = "label3";
            label3.Size = new Size(38, 18);
            label3.TabIndex = 26;
            label3.Text = "Filter";
            // 
            // cardviewcmbbxFilter
            // 
            cardviewcmbbxFilter.Font = new Font("Tahoma", 11.25F);
            cardviewcmbbxFilter.FormattingEnabled = true;
            cardviewcmbbxFilter.Items.AddRange(new object[] { "Chair", "Table", "Cabinet", "Sofa", "Bed", "Desk", "Shelf", "Dining Set", "Office", "Outdoor" });
            cardviewcmbbxFilter.Location = new Point(379, 14);
            cardviewcmbbxFilter.Name = "cardviewcmbbxFilter";
            cardviewcmbbxFilter.Size = new Size(195, 26);
            cardviewcmbbxFilter.TabIndex = 25;
            cardviewcmbbxFilter.SelectedIndexChanged += cardviewcmbbxFilter_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(41, 19);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 24;
            label4.Text = "Search";
            // 
            // cardviewtxtSearch
            // 
            cardviewtxtSearch.Font = new Font("Tahoma", 11.25F);
            cardviewtxtSearch.Location = new Point(99, 14);
            cardviewtxtSearch.Name = "cardviewtxtSearch";
            cardviewtxtSearch.Size = new Size(220, 26);
            cardviewtxtSearch.TabIndex = 23;
            cardviewtxtSearch.TextChanged += cardviewtxtSearch_TextChanged;
            // 
            // btnDisplayProducts
            // 
            btnDisplayProducts.Font = new Font("Tahoma", 11.25F);
            btnDisplayProducts.Location = new Point(700, 6);
            btnDisplayProducts.Name = "btnDisplayProducts";
            btnDisplayProducts.Size = new Size(223, 46);
            btnDisplayProducts.TabIndex = 22;
            btnDisplayProducts.Text = "refresh display";
            btnDisplayProducts.UseVisualStyleBackColor = true;
            btnDisplayProducts.Click += btnDisplayProducts_Click;
            // 
            // pnlProductsCardview
            // 
            pnlProductsCardview.AutoScroll = true;
            pnlProductsCardview.Location = new Point(41, 58);
            pnlProductsCardview.Name = "pnlProductsCardview";
            pnlProductsCardview.Size = new Size(882, 402);
            pnlProductsCardview.TabIndex = 0;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProducts";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabGridView.ResumeLayout(false);
            tabGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabCardView.ResumeLayout(false);
            tabCardView.PerformLayout();
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
        private Button gridviewbtnRefreshDisplay;
        private Button btnRemoveProduct;
        private Label label2;
        private ComboBox gridviewcmbbxFilter;
        private Label label1;
        private TextBox gridviewtxtSearch;
        private Label label3;
        private ComboBox cardviewcmbbxFilter;
        private Label label4;
        private TextBox cardviewtxtSearch;
        private Button gridviewbtnEditProduct;
    }
}