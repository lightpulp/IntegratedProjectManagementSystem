namespace IntegratedProjectManagementSystem.Projects
{
    partial class FormClickProject_AddEmployee
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
            btnCancel = new Button();
            btnSave = new Button();
            dgvEmployeeList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 8);
            label2.Name = "label2";
            label2.Size = new Size(167, 23);
            label2.TabIndex = 15;
            label2.Text = "Select Employee";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 12F);
            btnCancel.Location = new Point(524, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 37);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Tahoma", 12F);
            btnSave.Location = new Point(653, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 37);
            btnSave.TabIndex = 13;
            btnSave.Text = "Select";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Location = new Point(35, 34);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.Size = new Size(741, 264);
            dgvEmployeeList.TabIndex = 12;
            // 
            // FormClickProject_AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 374);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvEmployeeList);
            Name = "FormClickProject_AddEmployee";
            Text = "FormClickProject_AddEmployee";
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private DataGridView dgvEmployeeList;
    }
}