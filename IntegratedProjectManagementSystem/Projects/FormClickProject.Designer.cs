namespace IntegratedProjectManagementSystem.Projects
{
    partial class FormClickProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClickProject));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lblProjectDescription = new Label();
            lblDateCompleted = new Label();
            lblCompleted = new Label();
            lblTotalPrice = new Label();
            label3 = new Label();
            lblDiscount = new Label();
            lblDeadline = new Label();
            lblStatus = new Label();
            lblProjectType = new Label();
            label15 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            lblProjectID = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            lblNotes = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblClientEmail = new Label();
            panel3 = new Panel();
            lblClientAddress = new Label();
            lblClientContact = new Label();
            lblClientName = new Label();
            lblProjectName = new Label();
            panelProductList = new Panel();
            dgvProjectProductList = new DataGridView();
            label6 = new Label();
            panel5 = new Panel();
            btnRemoveProduct = new Button();
            btnSelectProduct = new Button();
            panel6 = new Panel();
            btnRemoveEmployee = new Button();
            panelEmployeeList = new Panel();
            btnSelectEmployee = new Button();
            label7 = new Label();
            btnCreateQuotation = new Button();
            btnCreateInvoice = new Button();
            btnEditProject = new Button();
            panel4 = new Panel();
            panel10 = new Panel();
            label1 = new Label();
            panel9 = new Panel();
            panel7 = new Panel();
            btnBack = new Button();
            navbarLeft = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            dgvProjectEmployeeList = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panelProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjectProductList).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            navbarLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjectEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblDateCompleted);
            panel1.Controls.Add(lblCompleted);
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblDeadline);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblProjectType);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblProjectID);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblProjectName);
            panel1.Location = new Point(3, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 329);
            panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblProjectDescription);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 100);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Description";
            // 
            // lblProjectDescription
            // 
            lblProjectDescription.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjectDescription.Location = new Point(15, 18);
            lblProjectDescription.Name = "lblProjectDescription";
            lblProjectDescription.Size = new Size(495, 77);
            lblProjectDescription.TabIndex = 12;
            lblProjectDescription.Text = "Project Description";
            // 
            // lblDateCompleted
            // 
            lblDateCompleted.AutoSize = true;
            lblDateCompleted.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateCompleted.Location = new Point(121, 209);
            lblDateCompleted.Name = "lblDateCompleted";
            lblDateCompleted.Size = new Size(62, 18);
            lblDateCompleted.TabIndex = 32;
            lblDateCompleted.Text = "Deadline";
            lblDateCompleted.Visible = false;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(28, 209);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(87, 18);
            lblCompleted.TabIndex = 31;
            lblCompleted.Text = "Completed :";
            lblCompleted.Visible = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(121, 239);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(32, 18);
            lblTotalPrice.TabIndex = 30;
            lblTotalPrice.Text = "500";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 239);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 29;
            label3.Text = "Price :";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(121, 263);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(32, 18);
            lblDiscount.TabIndex = 28;
            lblDiscount.Text = "500";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeadline.Location = new Point(121, 185);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(62, 18);
            lblDeadline.TabIndex = 27;
            lblDeadline.Text = "Deadline";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(121, 162);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 18);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Status";
            // 
            // lblProjectType
            // 
            lblProjectType.AutoSize = true;
            lblProjectType.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjectType.Location = new Point(121, 138);
            lblProjectType.Name = "lblProjectType";
            lblProjectType.Size = new Size(42, 18);
            lblProjectType.TabIndex = 25;
            lblProjectType.Text = "Type";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(42, 263);
            label15.Name = "label15";
            label15.Size = new Size(73, 18);
            label15.TabIndex = 23;
            label15.Text = "Discount :";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(13, 234);
            panel8.Name = "panel8";
            panel8.Size = new Size(500, 2);
            panel8.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(35, 290);
            label11.Name = "label11";
            label11.Size = new Size(80, 19);
            label11.TabIndex = 22;
            label11.Text = "Revenue";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 138);
            label12.Name = "label12";
            label12.Size = new Size(102, 18);
            label12.TabIndex = 21;
            label12.Text = "Project Type :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(43, 185);
            label10.Name = "label10";
            label10.Size = new Size(72, 18);
            label10.TabIndex = 19;
            label10.Text = "Deadline :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(56, 162);
            label9.Name = "label9";
            label9.Size = new Size(59, 18);
            label9.TabIndex = 17;
            label9.Text = "Status :";
            // 
            // lblProjectID
            // 
            lblProjectID.AutoSize = true;
            lblProjectID.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProjectID.Location = new Point(522, 13);
            lblProjectID.Name = "lblProjectID";
            lblProjectID.Size = new Size(19, 19);
            lblProjectID.TabIndex = 16;
            lblProjectID.Text = "1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblClientEmail);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblClientAddress);
            panel2.Controls.Add(lblClientContact);
            panel2.Controls.Add(lblClientName);
            panel2.Location = new Point(557, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 306);
            panel2.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNotes);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(23, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 138);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Client Notes";
            // 
            // lblNotes
            // 
            lblNotes.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(20, 18);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(327, 117);
            lblNotes.TabIndex = 22;
            lblNotes.Text = "Client Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 117);
            label5.Name = "label5";
            label5.Size = new Size(42, 14);
            label5.TabIndex = 25;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 91);
            label4.Name = "label4";
            label4.Size = new Size(58, 14);
            label4.TabIndex = 24;
            label4.Text = "Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 23;
            label2.Text = "Contact :";
            // 
            // lblClientEmail
            // 
            lblClientEmail.AutoSize = true;
            lblClientEmail.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientEmail.Location = new Point(82, 114);
            lblClientEmail.Name = "lblClientEmail";
            lblClientEmail.Size = new Size(121, 18);
            lblClientEmail.TabIndex = 17;
            lblClientEmail.Text = "Email@gmail.com";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(23, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 2);
            panel3.TabIndex = 16;
            // 
            // lblClientAddress
            // 
            lblClientAddress.AutoSize = true;
            lblClientAddress.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientAddress.Location = new Point(82, 88);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(185, 18);
            lblClientAddress.TabIndex = 15;
            lblClientAddress.Text = "St Narra 2 Guagua Bulacan";
            // 
            // lblClientContact
            // 
            lblClientContact.AutoSize = true;
            lblClientContact.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientContact.Location = new Point(82, 60);
            lblClientContact.Name = "lblClientContact";
            lblClientContact.Size = new Size(106, 18);
            lblClientContact.TabIndex = 14;
            lblClientContact.Text = "0915 289 5634";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientName.Location = new Point(23, 13);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(109, 19);
            lblClientName.TabIndex = 13;
            lblClientName.Text = "Client Name";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProjectName.Location = new Point(13, 13);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(111, 19);
            lblProjectName.TabIndex = 11;
            lblProjectName.Text = "Project Title";
            // 
            // panelProductList
            // 
            panelProductList.Controls.Add(dgvProjectProductList);
            panelProductList.Location = new Point(6, 68);
            panelProductList.Name = "panelProductList";
            panelProductList.Size = new Size(970, 279);
            panelProductList.TabIndex = 18;
            // 
            // dgvProjectProductList
            // 
            dgvProjectProductList.BackgroundColor = Color.White;
            dgvProjectProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectProductList.Location = new Point(17, 3);
            dgvProjectProductList.Name = "dgvProjectProductList";
            dgvProjectProductList.Size = new Size(934, 273);
            dgvProjectProductList.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(151, 19);
            label6.TabIndex = 19;
            label6.Text = "Products Ordered";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnRemoveProduct);
            panel5.Controls.Add(btnSelectProduct);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(3, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 46);
            panel5.TabIndex = 19;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.BackColor = Color.FromArgb(255, 192, 192);
            btnRemoveProduct.Location = new Point(721, 5);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(119, 33);
            btnRemoveProduct.TabIndex = 21;
            btnRemoveProduct.Text = "Remove Products";
            btnRemoveProduct.UseVisualStyleBackColor = false;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // btnSelectProduct
            // 
            btnSelectProduct.BackColor = Color.FromArgb(192, 255, 192);
            btnSelectProduct.Location = new Point(846, 5);
            btnSelectProduct.Name = "btnSelectProduct";
            btnSelectProduct.Size = new Size(120, 33);
            btnSelectProduct.TabIndex = 20;
            btnSelectProduct.Text = "Add Products";
            btnSelectProduct.UseVisualStyleBackColor = false;
            btnSelectProduct.Click += btnSelectProduct_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnRemoveEmployee);
            panel6.Controls.Add(panelEmployeeList);
            panel6.Controls.Add(btnSelectEmployee);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(3, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(970, 46);
            panel6.TabIndex = 21;
            // 
            // btnRemoveEmployee
            // 
            btnRemoveEmployee.BackColor = Color.FromArgb(255, 192, 192);
            btnRemoveEmployee.Location = new Point(721, 5);
            btnRemoveEmployee.Name = "btnRemoveEmployee";
            btnRemoveEmployee.Size = new Size(119, 33);
            btnRemoveEmployee.TabIndex = 21;
            btnRemoveEmployee.Text = "Remove Employee";
            btnRemoveEmployee.UseVisualStyleBackColor = false;
            // 
            // panelEmployeeList
            // 
            panelEmployeeList.Location = new Point(0, 44);
            panelEmployeeList.Name = "panelEmployeeList";
            panelEmployeeList.Size = new Size(970, 305);
            panelEmployeeList.TabIndex = 20;
            // 
            // btnSelectEmployee
            // 
            btnSelectEmployee.BackColor = Color.FromArgb(192, 255, 192);
            btnSelectEmployee.Location = new Point(846, 5);
            btnSelectEmployee.Name = "btnSelectEmployee";
            btnSelectEmployee.Size = new Size(120, 33);
            btnSelectEmployee.TabIndex = 20;
            btnSelectEmployee.Text = "Set Employee";
            btnSelectEmployee.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(185, 19);
            label7.TabIndex = 19;
            label7.Text = "Employees on Project";
            // 
            // btnCreateQuotation
            // 
            btnCreateQuotation.BackColor = Color.Transparent;
            btnCreateQuotation.Font = new Font("Tahoma", 11.25F, FontStyle.Italic);
            btnCreateQuotation.Location = new Point(1018, 5);
            btnCreateQuotation.Name = "btnCreateQuotation";
            btnCreateQuotation.Size = new Size(154, 33);
            btnCreateQuotation.TabIndex = 22;
            btnCreateQuotation.Text = "Create Quotation";
            btnCreateQuotation.UseVisualStyleBackColor = false;
            btnCreateQuotation.Click += btnCreateQuotation_Click;
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BackColor = Color.Transparent;
            btnCreateInvoice.Font = new Font("Tahoma", 11.25F, FontStyle.Italic);
            btnCreateInvoice.Location = new Point(858, 5);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.Size = new Size(154, 33);
            btnCreateInvoice.TabIndex = 23;
            btnCreateInvoice.Text = "Create Invoice";
            btnCreateInvoice.UseVisualStyleBackColor = false;
            // 
            // btnEditProject
            // 
            btnEditProject.BackColor = Color.Transparent;
            btnEditProject.Font = new Font("Tahoma", 11.25F, FontStyle.Italic);
            btnEditProject.Location = new Point(698, 5);
            btnEditProject.Name = "btnEditProject";
            btnEditProject.Size = new Size(154, 33);
            btnEditProject.TabIndex = 24;
            btnEditProject.Text = "Edit Project Details";
            btnEditProject.UseVisualStyleBackColor = false;
            btnEditProject.Click += btnEditProject_Click;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(184, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 505);
            panel4.TabIndex = 25;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label1);
            panel10.Location = new Point(3, 11);
            panel10.Name = "panel10";
            panel10.Size = new Size(970, 46);
            panel10.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 19;
            label1.Text = "Project Details";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Tan;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(dgvProjectEmployeeList);
            panel9.Controls.Add(panel6);
            panel9.Location = new Point(3, 790);
            panel9.Name = "panel9";
            panel9.Size = new Size(973, 350);
            panel9.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Tan;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel5);
            panel7.Controls.Add(panelProductList);
            panel7.Location = new Point(3, 417);
            panel7.Name = "panel7";
            panel7.Size = new Size(973, 350);
            panel7.TabIndex = 26;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.logout_circle_line1;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Location = new Point(192, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 33);
            btnBack.TabIndex = 26;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // navbarLeft
            // 
            navbarLeft.AutoSize = false;
            navbarLeft.BackColor = SystemColors.ControlLightLight;
            navbarLeft.Dock = DockStyle.Left;
            navbarLeft.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, btnDashboard, btnProjects, btnInventory, btnStaff, btnLogout });
            navbarLeft.Location = new Point(0, 0);
            navbarLeft.Name = "navbarLeft";
            navbarLeft.Padding = new Padding(7, 2, 0, 2);
            navbarLeft.Size = new Size(181, 561);
            navbarLeft.TabIndex = 27;
            navbarLeft.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(173, 19);
            toolStripMenuItem1.Text = " ";
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = false;
            btnDashboard.BackColor = Color.White;
            btnDashboard.Font = new Font("Segoe UI", 12F);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(181, 40);
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProjects
            // 
            btnProjects.AutoSize = false;
            btnProjects.BackColor = Color.White;
            btnProjects.Font = new Font("Segoe UI", 12F);
            btnProjects.Image = Properties.Resources.pie_chart_line;
            btnProjects.Name = "btnProjects";
            btnProjects.Padding = new Padding(0);
            btnProjects.Size = new Size(181, 40);
            btnProjects.Text = "Projects";
            btnProjects.Click += btnProjects_Click;
            // 
            // btnInventory
            // 
            btnInventory.AutoSize = false;
            btnInventory.BackColor = Color.White;
            btnInventory.Font = new Font("Segoe UI", 12F);
            btnInventory.Image = Properties.Resources.file_list_line;
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(0);
            btnInventory.Size = new Size(181, 40);
            btnInventory.Text = "Inventory";
            btnInventory.Click += btnInventory_Click;
            // 
            // btnStaff
            // 
            btnStaff.AutoSize = false;
            btnStaff.BackColor = Color.White;
            btnStaff.Font = new Font("Segoe UI", 12F);
            btnStaff.Image = Properties.Resources.user_2_line;
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(0);
            btnStaff.Size = new Size(181, 40);
            btnStaff.Text = "Staff";
            btnStaff.Click += btnStaff_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = false;
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.Image = Properties.Resources.logout_circle_line;
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(0);
            btnLogout.Size = new Size(181, 40);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvProjectEmployeeList
            // 
            dgvProjectEmployeeList.BackgroundColor = Color.White;
            dgvProjectEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectEmployeeList.Location = new Point(23, 63);
            dgvProjectEmployeeList.Name = "dgvProjectEmployeeList";
            dgvProjectEmployeeList.Size = new Size(934, 273);
            dgvProjectEmployeeList.TabIndex = 22;
            // 
            // FormClickProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1184, 561);
            Controls.Add(navbarLeft);
            Controls.Add(btnBack);
            Controls.Add(panel4);
            Controls.Add(btnEditProject);
            Controls.Add(btnCreateInvoice);
            Controls.Add(btnCreateQuotation);
            Name = "FormClickProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClickProject";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            panelProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjectProductList).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel7.ResumeLayout(false);
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjectEmployeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblProjectName;
        private Panel panel2;
        private Label lblClientName;
        private Label lblProjectDescription;
        private Label lblClientAddress;
        private Label lblClientContact;
        private Panel panel3;
        private Panel panelProductList;
        private Label label6;
        private Panel panel5;
        private Button btnSelectProduct;
        private Button btnRemoveProduct;
        private Panel panel6;
        private Button btnRemoveEmployee;
        private Button btnSelectEmployee;
        private Label label7;
        private Panel panelEmployeeList;
        private Button btnCreateQuotation;
        private Button btnCreateInvoice;
        private Label label9;
        private Label lblProjectID;
        private Button btnEditProject;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label lblNotes;
        private Label lblClientEmail;
        private Label label15;
        private Panel panel8;
        private DataGridView dgvProjectProductList;
        private Panel panel4;
        private Panel panel7;
        private Panel panel9;
        private Label lblProjectType;
        private Label lblStatus;
        private Label lblDeadline;
        private Label lblDiscount;
        private Button btnBack;
        private Label lblTotalPrice;
        private Label label3;
        private Label lblDateCompleted;
        private Label lblCompleted;
        private GroupBox groupBox1;
        private Panel panel10;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label2;
        private MenuStrip navbarLeft;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
        private DataGridView dgvProjectEmployeeList;
    }
}