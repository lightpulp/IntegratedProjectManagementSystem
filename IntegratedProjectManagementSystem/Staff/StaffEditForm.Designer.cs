namespace IntegratedProjectManagementSystem.Staff
{
    partial class StaffEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffEditForm));
            btnBrowse = new Button();
            picEmployee = new PictureBox();
            chkActive = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtEmail = new TextBox();
            label10 = new Label();
            maskedContact = new MaskedTextBox();
            cbStatus = new ComboBox();
            cbPosition = new ComboBox();
            numDailyRate = new NumericUpDown();
            dtBirthDate = new DateTimePicker();
            label9 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDailyRate).BeginInit();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(488, 371);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(223, 25);
            btnBrowse.TabIndex = 48;
            btnBrowse.Text = "Browse Image";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // picEmployee
            // 
            picEmployee.BackgroundImage = (Image)resources.GetObject("picEmployee.BackgroundImage");
            picEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            picEmployee.Location = new Point(451, 39);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(307, 313);
            picEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            picEmployee.TabIndex = 47;
            picEmployee.TabStop = false;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(57, 417);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 46;
            chkActive.Text = "Check";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(614, 399);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 58);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(488, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 58);
            btnSave.TabIndex = 44;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 373);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 23);
            txtEmail.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 399);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 42;
            label10.Text = "Active";
            // 
            // maskedContact
            // 
            maskedContact.Location = new Point(43, 329);
            maskedContact.Mask = "(63+) 000-0000-000";
            maskedContact.Name = "maskedContact";
            maskedContact.Size = new Size(338, 23);
            maskedContact.TabIndex = 41;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(43, 285);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(338, 23);
            cbStatus.TabIndex = 40;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "Cashier", "Wood Worker", "Delivery Driver" });
            cbPosition.Location = new Point(43, 241);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(338, 23);
            cbPosition.TabIndex = 39;
            // 
            // numDailyRate
            // 
            numDailyRate.Location = new Point(43, 197);
            numDailyRate.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numDailyRate.Name = "numDailyRate";
            numDailyRate.Size = new Size(338, 23);
            numDailyRate.TabIndex = 38;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Location = new Point(43, 145);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(338, 23);
            dtBirthDate.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(394, 218);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 36;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(43, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(338, 23);
            txtLastName.TabIndex = 35;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(43, 39);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(338, 23);
            txtFirstName.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 355);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 33;
            label8.Text = "E-Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 311);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 32;
            label7.Text = "Contact Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 267);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 31;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 223);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 30;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 179);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 29;
            label4.Text = "Daily Rate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 127);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 28;
            label3.Text = "Birth Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 27;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 26;
            label1.Text = "First Name";
            // 
            // StaffEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 474);
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
            Name = "StaffEditForm";
            Text = "StaffEditForm";
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDailyRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private PictureBox picEmployee;
        private CheckBox chkActive;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtEmail;
        private Label label10;
        private MaskedTextBox maskedContact;
        private ComboBox cbStatus;
        private ComboBox cbPosition;
        private NumericUpDown numDailyRate;
        private DateTimePicker dtBirthDate;
        private Label label9;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}