namespace IntegratedProjectManagementSystem.Projects
{
    partial class FormProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProject));
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cmbbxFilter = new ComboBox();
            btnCreateProject = new Button();
            pnlProjects = new Panel();
            navbarLeft = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            navbarLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cmbbxFilter);
            panel1.Controls.Add(btnCreateProject);
            panel1.Location = new Point(201, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 47);
            panel1.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(486, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 27);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(179, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(301, 27);
            txtSearch.TabIndex = 19;
            // 
            // cmbbxFilter
            // 
            cmbbxFilter.AccessibleDescription = "cmbbxFilter";
            cmbbxFilter.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbbxFilter.FormattingEnabled = true;
            cmbbxFilter.Items.AddRange(new object[] { "Initiated", "Quote Sent", "Ongoing", "Completed", "Canceled", "All Projects" });
            cmbbxFilter.Location = new Point(17, 9);
            cmbbxFilter.Name = "cmbbxFilter";
            cmbbxFilter.Size = new Size(156, 27);
            cmbbxFilter.TabIndex = 18;
            cmbbxFilter.SelectedIndexChanged += cmbbxFilter_SelectedIndexChanged;
            // 
            // btnCreateProject
            // 
            btnCreateProject.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateProject.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateProject.Location = new Point(681, 5);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(285, 33);
            btnCreateProject.TabIndex = 17;
            btnCreateProject.Text = "Create New Project";
            btnCreateProject.UseVisualStyleBackColor = true;
            btnCreateProject.Click += btnCreateProject_Click;
            btnCreateProject.MouseEnter += btnCreateProject_MouseEnter;
            // 
            // pnlProjects
            // 
            pnlProjects.AutoScroll = true;
            pnlProjects.BackColor = Color.Tan;
            pnlProjects.BorderStyle = BorderStyle.FixedSingle;
            pnlProjects.Location = new Point(201, 87);
            pnlProjects.Name = "pnlProjects";
            pnlProjects.Size = new Size(971, 462);
            pnlProjects.TabIndex = 18;
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
            navbarLeft.TabIndex = 19;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 6);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 20;
            label1.Text = "Projects";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BackgroundImage = Properties.Resources.add_box_line;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(936, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 27);
            panel2.TabIndex = 0;
            // 
            // FormProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1184, 561);
            Controls.Add(label1);
            Controls.Add(navbarLeft);
            Controls.Add(pnlProjects);
            Controls.Add(panel1);
            Name = "FormProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProject";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnCreateProject;
        private ComboBox cmbbxFilter;
        private Panel pnlProjects;
        private TextBox txtSearch;
        private Button btnSearch;
        private MenuStrip navbarLeft;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
        private Label label1;
        private Panel panel2;
    }
}