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
            btnSave = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtDimension = new TextBox();
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
            pboxImage = new PictureBox();
            btnCancel = new Button();
            btnChooseMaterials = new Button();
            btnChooseImage = new Button();
            dgvMaterialsUsed = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialsUsed).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(905, 348);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDimension);
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
            groupBox1.Location = new Point(37, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 303);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 232);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 29;
            label4.Text = "Dimension";
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(141, 232);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(121, 23);
            txtDimension.TabIndex = 28;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(141, 195);
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
            cbActive.Location = new Point(141, 272);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(15, 14);
            cbActive.TabIndex = 25;
            cbActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 271);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 24;
            label9.Text = "Active:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 203);
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
            // pboxImage
            // 
            pboxImage.Location = new Point(385, 19);
            pboxImage.Name = "pboxImage";
            pboxImage.Size = new Size(262, 267);
            pboxImage.TabIndex = 39;
            pboxImage.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(824, 348);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChooseMaterials
            // 
            btnChooseMaterials.Location = new Point(668, 292);
            btnChooseMaterials.Name = "btnChooseMaterials";
            btnChooseMaterials.Size = new Size(312, 23);
            btnChooseMaterials.TabIndex = 42;
            btnChooseMaterials.Text = "choose materials";
            btnChooseMaterials.UseVisualStyleBackColor = true;
            btnChooseMaterials.Click += btnChooseMaterials_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(385, 292);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(262, 23);
            btnChooseImage.TabIndex = 43;
            btnChooseImage.Text = "choose image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // dgvMaterialsUsed
            // 
            dgvMaterialsUsed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialsUsed.Location = new Point(668, 19);
            dgvMaterialsUsed.Name = "dgvMaterialsUsed";
            dgvMaterialsUsed.Size = new Size(312, 267);
            dgvMaterialsUsed.TabIndex = 44;
            // 
            // FormCreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 405);
            Controls.Add(dgvMaterialsUsed);
            Controls.Add(btnChooseImage);
            Controls.Add(btnChooseMaterials);
            Controls.Add(btnCancel);
            Controls.Add(pboxImage);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "FormCreateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialsUsed).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
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
        private Label label4;
        private TextBox txtDimension;
        private PictureBox pboxImage;
        private Button btnCancel;
        private Button btnChooseMaterials;
        private Button btnChooseImage;
        private DataGridView dgvMaterialsUsed;
    }
}