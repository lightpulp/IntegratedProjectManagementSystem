namespace IntegratedProjectManagementSystem.Inventory
{
    partial class FormCreateMaterial
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
            dgvMaterials = new DataGridView();
            btnClear = new Button();
            btnRefresh = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            txtUnitCost = new TextBox();
            label4 = new Label();
            txtUnitOfMeasure = new TextBox();
            txtCurrentStock = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtMaterialName = new TextBox();
            txtMaterialID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            cmbFilter = new ComboBox();
            label6 = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaterials).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMaterials
            // 
            dgvMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterials.Location = new Point(397, 23);
            dgvMaterials.Name = "dgvMaterials";
            dgvMaterials.Size = new Size(523, 531);
            dgvMaterials.TabIndex = 43;
            dgvMaterials.CellClick += dgvMaterials_CellClick;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 9.75F);
            btnClear.Location = new Point(186, 337);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 31);
            btnClear.TabIndex = 42;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Tahoma", 9.75F);
            btnRefresh.Location = new Point(87, 337);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(93, 31);
            btnRefresh.TabIndex = 41;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 9.75F);
            btnSave.Location = new Point(281, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 31);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUnitCost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUnitOfMeasure);
            groupBox1.Controls.Add(txtCurrentStock);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMaterialName);
            groupBox1.Controls.Add(txtMaterialID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 308);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // txtUnitCost
            // 
            txtUnitCost.Font = new Font("Tahoma", 9.75F);
            txtUnitCost.Location = new Point(141, 242);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(196, 23);
            txtUnitCost.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F);
            label4.Location = new Point(63, 242);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 28;
            label4.Text = "Unit cost :";
            // 
            // txtUnitOfMeasure
            // 
            txtUnitOfMeasure.Font = new Font("Tahoma", 9.75F);
            txtUnitOfMeasure.Location = new Point(141, 196);
            txtUnitOfMeasure.Name = "txtUnitOfMeasure";
            txtUnitOfMeasure.Size = new Size(196, 23);
            txtUnitOfMeasure.TabIndex = 27;
            // 
            // txtCurrentStock
            // 
            txtCurrentStock.Font = new Font("Tahoma", 9.75F);
            txtCurrentStock.Location = new Point(141, 156);
            txtCurrentStock.Name = "txtCurrentStock";
            txtCurrentStock.Size = new Size(196, 23);
            txtCurrentStock.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9.75F);
            label8.Location = new Point(21, 199);
            label8.Name = "label8";
            label8.Size = new Size(107, 16);
            label8.TabIndex = 23;
            label8.Text = "Unit of measure :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F);
            label7.Location = new Point(34, 159);
            label7.Name = "label7";
            label7.Size = new Size(94, 16);
            label7.TabIndex = 22;
            label7.Text = "Current Stock :";
            // 
            // txtMaterialName
            // 
            txtMaterialName.Font = new Font("Tahoma", 9.75F);
            txtMaterialName.Location = new Point(141, 71);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new Size(196, 23);
            txtMaterialName.TabIndex = 19;
            // 
            // txtMaterialID
            // 
            txtMaterialID.Font = new Font("Tahoma", 9.75F);
            txtMaterialID.Location = new Point(141, 32);
            txtMaterialID.Name = "txtMaterialID";
            txtMaterialID.ReadOnly = true;
            txtMaterialID.Size = new Size(196, 23);
            txtMaterialID.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F);
            label2.Location = new Point(29, 74);
            label2.Name = "label2";
            label2.Size = new Size(99, 16);
            label2.TabIndex = 18;
            label2.Text = "Material Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F);
            label1.Location = new Point(57, 35);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 16;
            label1.Text = "Product ID:";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Tahoma", 9.75F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Wood", "Fabric", "Hardware", "Finish", "Upholstery", "Glass", "Metal", "Plastic", "Foam", "Adhesive" });
            cmbCategory.Location = new Point(141, 110);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(196, 24);
            cmbCategory.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F);
            label3.Location = new Point(65, 113);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 20;
            label3.Text = "Category:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Tahoma", 9.75F);
            txtSearch.Location = new Point(162, 421);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(196, 23);
            txtSearch.TabIndex = 30;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F);
            label5.Location = new Point(93, 424);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 30;
            label5.Text = "Search :";
            // 
            // cmbFilter
            // 
            cmbFilter.Font = new Font("Tahoma", 9.75F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(162, 391);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(196, 24);
            cmbFilter.TabIndex = 30;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F);
            label6.Location = new Point(87, 394);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 45;
            label6.Text = "Filter by :";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(21, 529);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 46;
            btnClose.Text = "<-";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FormCreateMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 564);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(cmbFilter);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(groupBox1);
            Controls.Add(dgvMaterials);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(btnSave);
            Name = "FormCreateMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materials";
            ((System.ComponentModel.ISupportInitialize)dgvMaterials).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaterials;
        private Button btnClear;
        private Button btnRefresh;
        private Button btnSave;
        private GroupBox groupBox1;
        private TextBox txtUnitOfMeasure;
        private TextBox txtCurrentStock;
        private Label label8;
        private Label label7;
        private TextBox txtMaterialName;
        private TextBox txtMaterialID;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategory;
        private Label label3;
        private TextBox txtUnitCost;
        private Label label4;
        private TextBox txtSearch;
        private Label label5;
        private ComboBox cmbFilter;
        private Label label6;
        private Button btnClose;
    }
}