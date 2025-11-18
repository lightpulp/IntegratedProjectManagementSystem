namespace IntegratedProjectManagementSystem.Staff
{
    partial class TimeLogForm
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
            label2 = new Label();
            label3 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            chkTimeOut = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            lblName = new Label();
            lblRate = new Label();
            lblTimer = new Label();
            lblHoursWorked = new Label();
            lblSalary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 63);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 90);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Timer:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(74, 119);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start ";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(155, 119);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // chkTimeOut
            // 
            chkTimeOut.AutoSize = true;
            chkTimeOut.Location = new Point(53, 160);
            chkTimeOut.Name = "chkTimeOut";
            chkTimeOut.Size = new Size(76, 19);
            chkTimeOut.TabIndex = 5;
            chkTimeOut.Text = "Time Out";
            chkTimeOut.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 197);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 6;
            label4.Text = "Hours Worked:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 226);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 7;
            label5.Text = "Salary:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(107, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 8;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(107, 63);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(0, 15);
            lblRate.TabIndex = 9;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(107, 90);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 15);
            lblTimer.TabIndex = 10;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(107, 197);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(0, 15);
            lblHoursWorked.TabIndex = 11;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(107, 226);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(0, 15);
            lblSalary.TabIndex = 12;
            // 
            // TimeLogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSalary);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblTimer);
            Controls.Add(lblRate);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chkTimeOut);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TimeLogForm";
            Text = "TimeLogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnStart;
        private Button btnStop;
        private CheckBox chkTimeOut;
        private Label label4;
        private Label label5;
        private Label lblName;
        private Label lblRate;
        private Label lblTimer;
        private Label lblHoursWorked;
        private Label lblSalary;
    }
}