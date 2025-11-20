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
            navbarLeft = new MenuStrip();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            btnGotoProducts = new Button();
            btnGotoMaterials = new Button();
            navbarLeft.SuspendLayout();
            SuspendLayout();
            // 
            // navbarLeft
            // 
            navbarLeft.AutoSize = false;
            navbarLeft.BackColor = SystemColors.ButtonFace;
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
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1184, 561);
            Controls.Add(btnGotoMaterials);
            Controls.Add(btnGotoProducts);
            Controls.Add(navbarLeft);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventory";
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip navbarLeft;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ListBox listBox1;

        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
        private Button btnGotoProducts;
        private Button btnGotoMaterials;
    }
}