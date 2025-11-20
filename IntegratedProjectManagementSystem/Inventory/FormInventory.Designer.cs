namespace IntegratedProjectManagementSystem.Inventory
{
    partial class FormInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            btnGotoProducts = new Button();
            btnGotoMaterials = new Button();
            navbarLeft = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            navbarLeft.SuspendLayout();
            SuspendLayout();
            // 
            // btnGotoProducts
            // 
            btnGotoProducts.Location = new Point(242, 27);
            btnGotoProducts.Name = "btnGotoProducts";
            btnGotoProducts.Size = new Size(702, 153);
            btnGotoProducts.TabIndex = 34;
            btnGotoProducts.Text = "Products";
            btnGotoProducts.UseVisualStyleBackColor = true;
            btnGotoProducts.Click += btnGotoProducts_Click;
            // 
            // btnGotoMaterials
            // 
            btnGotoMaterials.Location = new Point(242, 278);
            btnGotoMaterials.Name = "btnGotoMaterials";
            btnGotoMaterials.Size = new Size(702, 172);
            btnGotoMaterials.TabIndex = 35;
            btnGotoMaterials.Text = "Material";
            btnGotoMaterials.UseVisualStyleBackColor = true;
            btnGotoMaterials.Click += btnGotoMaterials_Click;
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
            navbarLeft.TabIndex = 36;
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
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1184, 561);
            Controls.Add(navbarLeft);
            Controls.Add(btnGotoMaterials);
            Controls.Add(btnGotoProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventory";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Button btnGotoProducts;
        private Button btnGotoMaterials;
        private MenuStrip navbarLeft;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
    }
}