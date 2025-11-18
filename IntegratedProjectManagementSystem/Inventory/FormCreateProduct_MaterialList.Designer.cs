namespace IntegratedProjectManagementSystem.Inventory
{
    partial class FormCreateProduct_MaterialList
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
            dgvMaterialList = new DataGridView();
            btnSave = new Button();
            btnCancel = new Button();
            txtQuantity = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMaterialList).BeginInit();
            SuspendLayout();
            // 
            // dgvMaterialList
            // 
            dgvMaterialList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterialList.Location = new Point(31, 34);
            dgvMaterialList.Name = "dgvMaterialList";
            dgvMaterialList.Size = new Size(741, 264);
            dgvMaterialList.TabIndex = 0;
            dgvMaterialList.CellClick += dgvMaterialList_CellClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(697, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Select";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(597, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(439, 315);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 318);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "Quantity";
            // 
            // FormCreateProduct_MaterialList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvMaterialList);
            Name = "FormCreateProduct_MaterialList";
            Text = "FormCreateProduct_MaterialList";
            ((System.ComponentModel.ISupportInitialize)dgvMaterialList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaterialList;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtQuantity;
        private Label label1;
    }
}