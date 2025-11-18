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
            comboBox1 = new ComboBox();
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
            // 
            // btnProjects
            // 
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(173, 19);
            btnProjects.Text = "Projects";
            // 
            // btnInventory
            // 
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(173, 19);
            btnInventory.Text = "Inventory";
            // 
            // btnStaff
            // 
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(173, 19);
            btnStaff.Text = "Staff";
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 19);
            btnLogout.Text = "Logout";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnCreateProject);
            panel1.Location = new Point(184, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 47);
            panel1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(867, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 18;
            // 
            // btnCreateProject
            // 
            btnCreateProject.Location = new Point(3, 4);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(164, 40);
            btnCreateProject.TabIndex = 17;
            btnCreateProject.Text = "Create New Project";
            btnCreateProject.UseVisualStyleBackColor = true;
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // pnlProjects
            // 
            pnlProjects.Location = new Point(184, 74);
            pnlProjects.Name = "pnlProjects";
            pnlProjects.Size = new Size(1000, 354);
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
            Text = "FormProject";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            panel1.ResumeLayout(false);
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
        private ComboBox comboBox1;
        private Panel pnlProjects;
    }
}