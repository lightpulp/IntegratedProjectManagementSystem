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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialsUsed).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 11.25F);
            btnSave.Location = new Point(841, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 35);
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
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Italic);
            groupBox1.Location = new Point(20, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 334);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(28, 238);
            label4.Name = "label4";
            label4.Size = new Size(70, 14);
            label4.TabIndex = 29;
            label4.Text = "Dimension :";
            // 
            // txtDimension
            // 
            txtDimension.Font = new Font("Tahoma", 12F);
            txtDimension.Location = new Point(104, 231);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(218, 27);
            txtDimension.TabIndex = 28;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Font = new Font("Tahoma", 12F);
            txtSalePrice.Location = new Point(104, 194);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(218, 27);
            txtSalePrice.TabIndex = 27;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Tahoma", 12F);
            txtDescription.Location = new Point(104, 158);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(218, 27);
            txtDescription.TabIndex = 26;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(106, 270);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(15, 14);
            cbActive.TabIndex = 25;
            cbActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F);
            label9.Location = new Point(55, 270);
            label9.Name = "label9";
            label9.Size = new Size(45, 14);
            label9.TabIndex = 24;
            label9.Text = "Active:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F);
            label8.Location = new Point(35, 201);
            label8.Name = "label8";
            label8.Size = new Size(63, 14);
            label8.TabIndex = 23;
            label8.Text = "Sale Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F);
            label7.Location = new Point(27, 165);
            label7.Name = "label7";
            label7.Size = new Size(71, 14);
            label7.TabIndex = 22;
            label7.Text = "Description:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Tahoma", 12F);
            txtProductName.Location = new Point(104, 75);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(218, 27);
            txtProductName.TabIndex = 19;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Tahoma", 12F);
            txtProductID.Location = new Point(104, 36);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(218, 27);
            txtProductID.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(9, 82);
            label2.Name = "label2";
            label2.Size = new Size(89, 14);
            label2.TabIndex = 18;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 16;
            label1.Text = "Product ID:";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Tahoma", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(104, 117);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(218, 27);
            cmbCategory.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(38, 124);
            label3.Name = "label3";
            label3.Size = new Size(60, 14);
            label3.TabIndex = 20;
            label3.Text = "Category:";
            // 
            // pboxImage
            // 
            pboxImage.Location = new Point(6, 20);
            pboxImage.Name = "pboxImage";
            pboxImage.Size = new Size(274, 277);
            pboxImage.TabIndex = 39;
            pboxImage.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 11.25F);
            btnCancel.Location = new Point(674, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 35);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChooseMaterials
            // 
            btnChooseMaterials.Font = new Font("Tahoma", 11.25F);
            btnChooseMaterials.Location = new Point(668, 315);
            btnChooseMaterials.Name = "btnChooseMaterials";
            btnChooseMaterials.Size = new Size(318, 31);
            btnChooseMaterials.TabIndex = 42;
            btnChooseMaterials.Text = "choose materials";
            btnChooseMaterials.UseVisualStyleBackColor = true;
            btnChooseMaterials.Click += btnChooseMaterials_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Font = new Font("Tahoma", 11.25F);
            btnChooseImage.Location = new Point(376, 315);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(286, 31);
            btnChooseImage.TabIndex = 43;
            btnChooseImage.Text = "choose image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // dgvMaterialsUsed
            // 
            dgvMaterialsUsed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialsUsed.Location = new Point(6, 17);
            dgvMaterialsUsed.Name = "dgvMaterialsUsed";
            dgvMaterialsUsed.Size = new Size(312, 280);
            dgvMaterialsUsed.TabIndex = 44;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMaterialsUsed);
            groupBox2.Font = new Font("Tahoma", 11.25F, FontStyle.Italic);
            groupBox2.Location = new Point(668, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 303);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Material List";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pboxImage);
            groupBox3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(376, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(286, 303);
            groupBox3.TabIndex = 46;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Image";
            // 
            // FormCreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 405);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnChooseImage);
            Controls.Add(btnChooseMaterials);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "FormCreateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateProduct";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialsUsed).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}