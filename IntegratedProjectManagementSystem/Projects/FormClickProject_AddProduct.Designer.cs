namespace IntegratedProjectManagementSystem.Projects
{
    partial class FormClickProject_AddProduct
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
            label2 = new Label();
            label1 = new Label();
            txtQuantity = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            dgvProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 11);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 11;
            label2.Text = "Select Products";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(31, 314);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 10;
            label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(137, 314);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(151, 26);
            txtQuantity.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 12F);
            btnCancel.Location = new Point(520, 307);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 37);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 12F);
            btnSave.Location = new Point(649, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 37);
            btnSave.TabIndex = 7;
            btnSave.Text = "Select";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(31, 37);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.Size = new Size(741, 264);
            dgvProductList.TabIndex = 6;
            // 
            // FormClickProject_AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 366);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvProductList);
            Name = "FormClickProject_AddProduct";
            Text = "FormClickProject_AddProduct";
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtQuantity;
        private Button btnCancel;
        private Button btnSave;
        private DataGridView dgvProductList;
    }
}