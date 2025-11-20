namespace IntegratedProjectManagementSystem.Staff
{
    partial class AttendanceEdit
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtClockIn = new TextBox();
            txtClockOut = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            dtpDay = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 45);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 2;
            label3.Text = "Day:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 75);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 3;
            label4.Text = "Clock In:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 105);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 4;
            label5.Text = "Clock Out:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(83, 15);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(333, 26);
            txtName.TabIndex = 5;
            // 
            // txtClockIn
            // 
            txtClockIn.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClockIn.Location = new Point(83, 71);
            txtClockIn.Name = "txtClockIn";
            txtClockIn.Size = new Size(333, 26);
            txtClockIn.TabIndex = 8;
            // 
            // txtClockOut
            // 
            txtClockOut.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClockOut.Location = new Point(83, 101);
            txtClockOut.Name = "txtClockOut";
            txtClockOut.Size = new Size(333, 26);
            txtClockOut.TabIndex = 9;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Tahoma", 11.25F);
            btnConfirm.Location = new Point(144, 165);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(86, 30);
            btnConfirm.TabIndex = 19;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 11.25F);
            btnCancel.Location = new Point(236, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 30);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpDay
            // 
            dtpDay.Location = new Point(83, 43);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new Size(333, 23);
            dtpDay.TabIndex = 21;
            // 
            // AttendanceEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(440, 202);
            Controls.Add(dtpDay);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtClockOut);
            Controls.Add(txtClockIn);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AttendanceEdit";
            Text = "AttendanceEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtClockIn;
        private TextBox txtClockOut;
        private Button btnConfirm;
        private Button btnCancel;
        private DateTimePicker dtpDay;
    }
}