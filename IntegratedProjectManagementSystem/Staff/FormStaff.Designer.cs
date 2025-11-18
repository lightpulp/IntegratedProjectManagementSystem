namespace IntegratedProjectManagementSystem.Staff
{
    partial class FormStaff
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
            dataGridEmployee = new DataGridView();
            txtSearch = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnInOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            SuspendLayout();
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Location = new Point(39, 46);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.Size = new Size(1133, 415);
            dataGridEmployee.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(39, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1133, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(902, 481);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 68);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(994, 481);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 68);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1086, 481);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 68);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInOut
            // 
            btnInOut.Location = new Point(810, 481);
            btnInOut.Name = "btnInOut";
            btnInOut.Size = new Size(86, 68);
            btnInOut.TabIndex = 6;
            btnInOut.Text = "Time In/Outs";
            btnInOut.UseVisualStyleBackColor = true;
            btnInOut.Click += btnInOut_Click;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(btnInOut);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridEmployee);
            Name = "FormStaff";
            Text = "FormStaff";
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridEmployee;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnInOut;
    }
}