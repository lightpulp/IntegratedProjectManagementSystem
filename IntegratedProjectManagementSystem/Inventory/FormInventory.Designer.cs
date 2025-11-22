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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            navbarLeft = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            navbarLeft.SuspendLayout();
            SuspendLayout();
            // 
            // btnGotoProducts
            // 
            btnGotoProducts.BackColor = Color.White;
            btnGotoProducts.Location = new Point(100, 301);
            btnGotoProducts.Name = "btnGotoProducts";
            btnGotoProducts.Size = new Size(97, 60);
            btnGotoProducts.TabIndex = 34;
            btnGotoProducts.Text = "Products";
            btnGotoProducts.UseVisualStyleBackColor = false;
            btnGotoProducts.Click += btnGotoProducts_Click;
            // 
            // btnGotoMaterials
            // 
            btnGotoMaterials.Location = new Point(110, 301);
            btnGotoMaterials.Name = "btnGotoMaterials";
            btnGotoMaterials.Size = new Size(97, 60);
            btnGotoMaterials.TabIndex = 35;
            btnGotoMaterials.Text = "Material";
            btnGotoMaterials.UseVisualStyleBackColor = true;
            btnGotoMaterials.Click += btnGotoMaterials_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.table;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(66, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.wood1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(69, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGotoProducts);
            panel1.Location = new Point(275, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 457);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnGotoMaterials);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(734, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 457);
            panel2.TabIndex = 39;
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
            navbarLeft.TabIndex = 40;
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
            btnDashboard.Click += btnDashboard_Click_1;
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
            btnProjects.Click += btnProjects_Click_1;
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
            btnInventory.Click += btnInventory_Click_1;
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
            btnStaff.Click += btnStaff_Click_1;
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
            btnLogout.Click += btnLogout_Click_1;
            // 
            // FormInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1184, 561);
            Controls.Add(navbarLeft);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Button btnGotoProducts;
        private Button btnGotoMaterials;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip navbarLeft;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
    }
}