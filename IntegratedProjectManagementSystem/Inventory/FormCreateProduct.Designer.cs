namespace IntegratedProjectManagementSystem.Inventory
{
    partial class FormCreateProduct
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
            dataGridViewProducts = new DataGridView();
            BtnClear = new Button();
            BtnRefresh = new Button();
            BtnSave = new Button();
            groupBox1 = new GroupBox();
            txtSalePrice = new TextBox();
            txtDescription = new TextBox();
            cbActive = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtSpecialInstruction = new TextBox();
            txtCustomDimension = new TextBox();
            txtCustomMaterial = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(385, 21);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(656, 477);
            dataGridViewProducts.TabIndex = 39;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(796, 504);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 38;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Location = new Point(966, 504);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(75, 23);
            BtnRefresh.TabIndex = 37;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(689, 504);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 34;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(56, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 259);
            groupBox1.TabIndex = 35;
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
            // txtProductName
            // 
            txtProductName.Location = new Point(141, 71);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(121, 23);
            txtProductName.TabIndex = 19;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 16;
            label1.Text = "Product ID:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(141, 118);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 21;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSpecialInstruction);
            groupBox2.Controls.Add(txtCustomDimension);
            groupBox2.Controls.Add(txtCustomMaterial);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(58, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(312, 250);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customization";
            // 
            // txtSpecialInstruction
            // 
            txtSpecialInstruction.Location = new Point(154, 156);
            txtSpecialInstruction.Multiline = true;
            txtSpecialInstruction.Name = "txtSpecialInstruction";
            txtSpecialInstruction.Size = new Size(124, 87);
            txtSpecialInstruction.TabIndex = 27;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 40);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 22;
            label4.Text = "Custom Dimension:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 97);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 23;
            label5.Text = "Custom Materials:";
            // 
            // FormCreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 561);
            Controls.Add(dataGridViewProducts);
            Controls.Add(BtnClear);
            Controls.Add(BtnRefresh);
            Controls.Add(BtnSave);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormCreateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button BtnClear;
        private Button BtnRefresh;
        private Button BtnSave;
        private GroupBox groupBox1;
        private TextBox txtSalePrice;
        private TextBox txtDescription;
        private CheckBox cbActive;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategory;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtSpecialInstruction;
        private TextBox txtCustomDimension;
        private TextBox txtCustomMaterial;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}