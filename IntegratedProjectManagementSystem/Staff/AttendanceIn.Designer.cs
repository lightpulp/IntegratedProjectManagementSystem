namespace IntegratedProjectManagementSystem.Staff
{
    partial class AttendanceIn
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
            label1 = new Label();
            cmbEmployee = new ComboBox();
            label2 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 48);
            label1.Name = "label1";
            label1.Size = new Size(145, 18);
            label1.TabIndex = 0;
            label1.Text = "Choose an Employee";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(54, 69);
            cmbEmployee.MinimumSize = new Size(10, 0);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(270, 23);
            cmbEmployee.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 9);
            label2.Name = "label2";
            label2.Size = new Size(203, 23);
            label2.TabIndex = 2;
            label2.Text = "Attendance Clock In";
            label2.Click += label2_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Tahoma", 11.25F);
            btnConfirm.Location = new Point(54, 98);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(130, 54);
            btnConfirm.TabIndex = 22;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 11.25F);
            btnCancel.Location = new Point(194, 98);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 54);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AttendanceIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 178);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(cmbEmployee);
            Controls.Add(label1);
            Name = "AttendanceIn";
            Text = "AttendanceIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbEmployee;
        private Label label2;
        private Button btnConfirm;
        private Button btnCancel;
    }
}