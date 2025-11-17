namespace IntegratedProjectManagementSystem.Inventory
{
    partial class FormInventory
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

            label1 = new Label();
            txtProductID = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtCustomDimension = new TextBox();
            txtCustomMaterial = new TextBox();
            label6 = new Label();
            txtSpecialInstruction = new TextBox();
            BtnSave = new Button();
            groupBox1 = new GroupBox();
            txtSalePrice = new TextBox();
            txtDescription = new TextBox();
            cbActive = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            BtnClear = new Button();
            BtnRefresh = new Button();
            dataGridViewProducts = new DataGridView();

            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            navbarLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // navbarLeft
            // 
            navbarLeft.AutoSize = false;
            navbarLeft.BackColor = SystemColors.ButtonFace;
            navbarLeft.Dock = DockStyle.Left;
            navbarLeft.Items.AddRange(new ToolStripItem[] { btnDashboard, btnProjects, btnInventory, btnStaff, btnLogout });
            navbarLeft.Location = new Point(0, 0);
            navbarLeft.Name = "navbarLeft";
            navbarLeft.Padding = new Padding(7, 2, 0, 2);
            navbarLeft.Size = new Size(181, 561);
            navbarLeft.TabIndex = 15;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 16;
            label1.Text = "Product ID:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(141, 32);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(121, 23);
            txtProductID.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 74);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 18;
            label2.Text = "Product Name:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(141, 71);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(121, 23);
            txtProductName.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 118);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 20;
            label3.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(141, 118);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 40);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 22;
            label4.Text = "Custom Dimension:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 97);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 23;
            label5.Text = "Custom Materials:";
            // 
            // txtCustomDimension
            // 
            txtCustomDimension.Location = new Point(157, 37);
            txtCustomDimension.Name = "txtCustomDimension";
            txtCustomDimension.Size = new Size(121, 23);
            txtCustomDimension.TabIndex = 24;
            // 
            // txtCustomMaterial
            // 
            txtCustomMaterial.Location = new Point(157, 94);
            txtCustomMaterial.Name = "txtCustomMaterial";
            txtCustomMaterial.Size = new Size(121, 23);
            txtCustomMaterial.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 159);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 26;
            label6.Text = "Special Instructions:";
            // 
            // txtSpecialInstruction
            // 
            txtSpecialInstruction.Location = new Point(154, 156);
            txtSpecialInstruction.Multiline = true;
            txtSpecialInstruction.Name = "txtSpecialInstruction";
            txtSpecialInstruction.Size = new Size(124, 87);
            txtSpecialInstruction.TabIndex = 27;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(609, 462);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 28;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSalePrice);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(cbActive);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(199, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 259);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(141, 203);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(121, 23);
            txtSalePrice.TabIndex = 27;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(141, 159);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 23);
            txtDescription.TabIndex = 26;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(146, 236);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(15, 14);
            cbActive.TabIndex = 25;
            cbActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 241);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 24;
            label9.Text = "Active:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1, 203);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 23;
            label8.Text = "Sale Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 167);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 22;
            label7.Text = "Description:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSpecialInstruction);
            groupBox2.Controls.Add(txtCustomDimension);
            groupBox2.Controls.Add(txtCustomMaterial);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(201, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 250);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customization";
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(716, 462);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 32;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(833, 462);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(75, 23);
            BtnRefresh.TabIndex = 31;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(531, 37);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(605, 407);
            dataGridViewProducts.TabIndex = 33;
            dataGridViewProducts.CellContentClick += dataGridViewProducts_CellClick;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1148, 532);
            Controls.Add(dataGridViewProducts);
            Controls.Add(BtnClear);
            Controls.Add(BtnRefresh);
            Controls.Add(BtnSave);
            ClientSize = new Size(1184, 561);
            Controls.Add(navbarLeft);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventory";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip navbarLeft;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;

        private Label label1;
        private TextBox txtProductID;
        private Label label2;
        private TextBox txtProductName;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label5;
        private TextBox txtCustomDimension;
        private TextBox txtCustomMaterial;
        private Label label6;
        private ListBox listBox1;
        private TextBox txtSpecialInstruction;
        private Button BtnSave;
        private GroupBox groupBox1;
        private TextBox txtSalePrice;
        private TextBox txtDescription;
        private CheckBox cbActive;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private Button BtnRefresh;
        private Button BtnClear;
        private DataGridView dataGridViewProducts;

        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;

    }
}