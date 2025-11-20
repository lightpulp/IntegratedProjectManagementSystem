namespace IntegratedProjectManagementSystem.Staff
{
    partial class AttendanceOut
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
            btnCancel = new Button();
            btnConfirm = new Button();
            label2 = new Label();
            cmbEmployee = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 11.25F);
            btnCancel.Location = new Point(208, 107);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 54);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Tahoma", 11.25F);
            btnConfirm.Location = new Point(68, 107);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(130, 54);
            btnConfirm.TabIndex = 27;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 18);
            label2.Name = "label2";
            label2.Size = new Size(217, 23);
            label2.TabIndex = 26;
            label2.Text = "Attendance Clock Out";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(68, 78);
            cmbEmployee.MinimumSize = new Size(10, 0);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(270, 23);
            cmbEmployee.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 57);
            label1.Name = "label1";
            label1.Size = new Size(145, 18);
            label1.TabIndex = 24;
            label1.Text = "Choose an Employee";
            // 
            // AttendanceOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 178);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(cmbEmployee);
            Controls.Add(label1);
            Name = "AttendanceOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendanceOut";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnConfirm;
        private Label label2;
        private ComboBox cmbEmployee;
        private Label label1;
    }
}