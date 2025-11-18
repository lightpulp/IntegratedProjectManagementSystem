namespace IntegratedProjectManagementSystem.Staff
{
    partial class StaffAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAddForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label9 = new Label();
            dtBirthDate = new DateTimePicker();
            numDailyRate = new NumericUpDown();
            cbPosition = new ComboBox();
            cbStatus = new ComboBox();
            maskedContact = new MaskedTextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            chkActive = new CheckBox();
            picEmployee = new PictureBox();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)numDailyRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 127);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 179);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Daily Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 223);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 267);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 311);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 6;
            label7.Text = "Contact Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 355);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 7;
            label8.Text = "E-Mail";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(338, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(30, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(338, 23);
            txtLastName.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(381, 218);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 13;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(30, 145);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(338, 23);
            dtBirthDate.TabIndex = 14;
            // 
            // numDailyRate
            // 
            numDailyRate.Location = new Point(30, 197);
            numDailyRate.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numDailyRate.Name = "numDailyRate";
            numDailyRate.Size = new Size(338, 23);
            numDailyRate.TabIndex = 15;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "Cashier", "Wood Worker", "Delivery Driver" });
            cbPosition.Location = new Point(30, 241);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(338, 23);
            cbPosition.TabIndex = 16;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(30, 285);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(338, 23);
            cbStatus.TabIndex = 17;
            // 
            // maskedContact
            // 
            maskedContact.Location = new Point(30, 329);
            maskedContact.Mask = "(63+) 000-0000-000";
            maskedContact.Name = "maskedContact";
            maskedContact.Size = new Size(338, 23);
            maskedContact.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 399);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 19;
            label10.Text = "Active";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 373);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 23);
            txtEmail.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(475, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 58);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(601, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 58);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(44, 417);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 23;
            chkActive.Text = "Check";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // picEmployee
            // 
            picEmployee.BackgroundImage = (Image)resources.GetObject("picEmployee.BackgroundImage");
            picEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            picEmployee.Location = new Point(438, 39);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(307, 313);
            picEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmployee.TabIndex = 24;
            picEmployee.TabStop = false;
            picEmployee.Click += picEmployee_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(475, 371);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(223, 25);
            btnBrowse.TabIndex = 25;
            btnBrowse.Text = "Browse Image";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // StaffAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 480);
            Controls.Add(btnBrowse);
            Controls.Add(picEmployee);
            Controls.Add(chkActive);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(maskedContact);
            Controls.Add(cbStatus);
            Controls.Add(cbPosition);
            Controls.Add(numDailyRate);
            Controls.Add(dtBirthDate);
            Controls.Add(label9);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffAddForm";
            Text = "StaffAddForm";
            ((System.ComponentModel.ISupportInitialize)numDailyRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label9;
        private DateTimePicker dtBirthDate;
        private NumericUpDown numDailyRate;
        private ComboBox cbPosition;
        private ComboBox cbStatus;
        private MaskedTextBox maskedContact;
        private Label label10;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox chkActive;
        private PictureBox picEmployee;
        private Button btnBrowse;
    }
}