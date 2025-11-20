namespace IntegratedProjectManagementSystem.Projects
{
    partial class FormCreateProject
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
            txtProjectName = new TextBox();
            txtProjectDescription = new TextBox();
            label1 = new Label();
            txtClientName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtClientNotes = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            txtContact = new TextBox();
            label5 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            cmbbxProjectStatus = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            txtDiscount = new TextBox();
            label6 = new Label();
            cmbbxProjectType = new ComboBox();
            label2 = new Label();
            clndrDeadline = new MonthCalendar();
            btnSaveProject = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtProjectName
            // 
            txtProjectName.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProjectName.Location = new Point(25, 39);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(714, 36);
            txtProjectName.TabIndex = 0;
            txtProjectName.Text = "Project Name";
            // 
            // txtProjectDescription
            // 
            txtProjectDescription.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProjectDescription.Location = new Point(153, 91);
            txtProjectDescription.Multiline = true;
            txtProjectDescription.Name = "txtProjectDescription";
            txtProjectDescription.Size = new Size(586, 93);
            txtProjectDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 95);
            label1.Name = "label1";
            label1.Size = new Size(138, 18);
            label1.TabIndex = 2;
            label1.Text = "Project Description :";
            // 
            // txtClientName
            // 
            txtClientName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientName.Location = new Point(139, 37);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(586, 27);
            txtClientName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 41);
            label3.Name = "label3";
            label3.Size = new Size(96, 18);
            label3.TabIndex = 5;
            label3.Text = "Client Name :";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(txtClientNotes);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtClientName);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 300);
            panel1.TabIndex = 6;
            // 
            // txtClientNotes
            // 
            txtClientNotes.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClientNotes.Location = new Point(139, 214);
            txtClientNotes.Multiline = true;
            txtClientNotes.Name = "txtClientNotes";
            txtClientNotes.Size = new Size(586, 66);
            txtClientNotes.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(38, 218);
            label11.Name = "label11";
            label11.Size = new Size(95, 18);
            label11.TabIndex = 17;
            label11.Text = "Client Notes :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(139, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(586, 27);
            txtEmail.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(82, 174);
            label12.Name = "label12";
            label12.Size = new Size(51, 18);
            label12.TabIndex = 15;
            label12.Text = "Email :";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(139, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(586, 27);
            txtAddress.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(63, 128);
            label9.Name = "label9";
            label9.Size = new Size(70, 18);
            label9.TabIndex = 13;
            label9.Text = "Address :";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(139, 81);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(586, 27);
            txtContact.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 85);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 11;
            label5.Text = "Contact # :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 192, 255);
            label8.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(295, 9);
            label8.Name = "label8";
            label8.Size = new Size(171, 23);
            label8.TabIndex = 9;
            label8.Text = "CLIENT DETAILS";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cmbbxProjectStatus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDiscount);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbbxProjectType);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(clndrDeadline);
            panel2.Controls.Add(txtProjectName);
            panel2.Controls.Add(txtProjectDescription);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 300);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Location = new Point(282, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 44);
            panel3.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 313);
            label10.Name = "label10";
            label10.Size = new Size(109, 18);
            label10.TabIndex = 12;
            label10.Text = "Project Status :";
            // 
            // cmbbxProjectStatus
            // 
            cmbbxProjectStatus.Font = new Font("Tahoma", 12F);
            cmbbxProjectStatus.FormattingEnabled = true;
            cmbbxProjectStatus.Items.AddRange(new object[] { "Initiated", "Quote Sent", "Ongoing", "Completed", "Canceled" });
            cmbbxProjectStatus.Location = new Point(153, 309);
            cmbbxProjectStatus.Name = "cmbbxProjectStatus";
            cmbbxProjectStatus.Size = new Size(245, 27);
            cmbbxProjectStatus.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(312, 9);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 5;
            label4.Text = "PROJECT DETAILS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(74, 260);
            label7.Name = "label7";
            label7.Size = new Size(73, 18);
            label7.TabIndex = 10;
            label7.Text = "Discount :";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(153, 256);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(245, 27);
            txtDiscount.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 211);
            label6.Name = "label6";
            label6.Size = new Size(102, 18);
            label6.TabIndex = 8;
            label6.Text = "Project Type :";
            // 
            // cmbbxProjectType
            // 
            cmbbxProjectType.Font = new Font("Tahoma", 12F);
            cmbbxProjectType.FormattingEnabled = true;
            cmbbxProjectType.Items.AddRange(new object[] { "Custom", "Standard", "Residential", "Commercial" });
            cmbbxProjectType.Location = new Point(153, 207);
            cmbbxProjectType.Name = "cmbbxProjectType";
            cmbbxProjectType.Size = new Size(245, 27);
            cmbbxProjectType.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 211);
            label2.Name = "label2";
            label2.Size = new Size(72, 18);
            label2.TabIndex = 6;
            label2.Text = "Deadline :";
            // 
            // clndrDeadline
            // 
            clndrDeadline.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clndrDeadline.Location = new Point(509, 207);
            clndrDeadline.Name = "clndrDeadline";
            clndrDeadline.TabIndex = 5;
            // 
            // btnSaveProject
            // 
            btnSaveProject.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveProject.Location = new Point(609, 627);
            btnSaveProject.Name = "btnSaveProject";
            btnSaveProject.Size = new Size(179, 46);
            btnSaveProject.TabIndex = 8;
            btnSaveProject.Text = "Save Project";
            btnSaveProject.UseVisualStyleBackColor = true;
            btnSaveProject.Click += btnSaveProject_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(466, 627);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 46);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormCreateProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProject);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCreateProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateProject";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtProjectName;
        private TextBox txtProjectDescription;
        private Label label1;
        private TextBox txtClientName;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private MonthCalendar clndrDeadline;
        private Label label4;
        private Label label6;
        private ComboBox cmbbxProjectType;
        private Label label2;
        private Label label7;
        private TextBox txtDiscount;
        private Label label13;
        private TextBox txtClientNotes;
        private Label label11;
        private TextBox txtEmail;
        private Label label12;
        private TextBox txtAddress;
        private Label label9;
        private TextBox txtContact;
        private Label label5;
        private Label label8;
        private Button btnSaveProject;
        private Button btnCancel;
        private Label label10;
        private ComboBox cmbbxProjectStatus;
        private Panel panel3;
    }
}