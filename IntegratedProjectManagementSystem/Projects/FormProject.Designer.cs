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
            navbarLeft = new MenuStrip();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            panel1 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cmbbxFilter = new ComboBox();
            btnCreateProject = new Button();
            pnlProjects = new Panel();
            navbarLeft.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // navbarLeft
            // 
            navbarLeft.AutoSize = false;
            navbarLeft.BackColor = SystemColors.ActiveCaption;
            navbarLeft.Dock = DockStyle.Left;
            navbarLeft.Items.AddRange(new ToolStripItem[] { btnDashboard, btnProjects, btnInventory, btnStaff, btnLogout });
            navbarLeft.Location = new Point(0, 0);
            navbarLeft.Name = "navbarLeft";
            navbarLeft.Padding = new Padding(7, 2, 0, 2);
            navbarLeft.Size = new Size(181, 561);
            navbarLeft.TabIndex = 15;
            navbarLeft.Text = "menuStrip1";
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = false;
            btnDashboard.BackColor = Color.FromArgb(128, 128, 255);
            btnDashboard.Margin = new Padding(10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(148, 40);
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProjects
            // 
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(173, 19);
            btnProjects.Text = "Projects";
            btnProjects.Click += btnProjects_Click;
            // 
            // btnInventory
            // 
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(173, 19);
            btnInventory.Text = "Inventory";
            btnInventory.Click += btnInventory_Click;
            // 
            // btnStaff
            // 
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(173, 19);
            btnStaff.Text = "Staff";
            btnStaff.Click += btnStaff_Click;
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 19);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cmbbxFilter);
            panel1.Controls.Add(btnCreateProject);
            panel1.Location = new Point(184, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 47);
            panel1.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(503, 10);
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
            btnCreateProject.Location = new Point(703, 3);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(285, 40);
            btnCreateProject.TabIndex = 17;
            btnCreateProject.Text = "Create New Project";
            btnCreateProject.UseVisualStyleBackColor = true;
            btnCreateProject.Click += btnCreateProject_Click;
            btnCreateProject.MouseEnter += btnCreateProject_MouseEnter;
            // 
            // pnlProjects
            // 
            pnlProjects.AutoScroll = true;
            pnlProjects.Location = new Point(184, 53);
            pnlProjects.Name = "pnlProjects";
            pnlProjects.Size = new Size(1000, 496);
            pnlProjects.TabIndex = 18;
            // 
            // FormProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(pnlProjects);
            Controls.Add(panel1);
            Controls.Add(navbarLeft);
            Name = "FormProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProject";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip navbarLeft;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
        private Panel panel1;
        private Button btnCreateProject;
        private ComboBox cmbbxFilter;
        private Panel pnlProjects;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}