namespace IntegratedProjectManagementSystem.Staff
{
    partial class AttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            dgvAttendance = new DataGridView();
            btnClockIn = new Button();
            btnClockOut = new Button();
            btnExport = new Button();
            btnEdit = new Button();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            btnBack = new Button();
            btnRemove = new Button();
            btnSalary = new Button();
            navbarLeft = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            navbarLeft.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(314, 73);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.Size = new Size(858, 474);
            dgvAttendance.TabIndex = 0;
            // 
            // btnClockIn
            // 
            btnClockIn.Font = new Font("Tahoma", 11.25F);
            btnClockIn.Location = new Point(206, 73);
            btnClockIn.Name = "btnClockIn";
            btnClockIn.Size = new Size(86, 68);
            btnClockIn.TabIndex = 18;
            btnClockIn.Text = "Clock In";
            btnClockIn.UseVisualStyleBackColor = true;
            btnClockIn.Click += btnClockIn_Click;
            // 
            // btnClockOut
            // 
            btnClockOut.Font = new Font("Tahoma", 11.25F);
            btnClockOut.Location = new Point(206, 147);
            btnClockOut.Name = "btnClockOut";
            btnClockOut.Size = new Size(86, 68);
            btnClockOut.TabIndex = 19;
            btnClockOut.Text = "Clock Out";
            btnClockOut.UseVisualStyleBackColor = true;
            btnClockOut.Click += btnClockOut_Click;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Tahoma", 11.25F);
            btnExport.Location = new Point(206, 369);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(86, 68);
            btnExport.TabIndex = 20;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Tahoma", 11.25F);
            btnEdit.Location = new Point(206, 221);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 68);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 22;
            label1.Text = "Date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(374, 33);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(213, 23);
            dateTimePicker.TabIndex = 24;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Tahoma", 11.25F);
            btnBack.Location = new Point(206, 517);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 30);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Tahoma", 11.25F);
            btnRemove.Location = new Point(206, 295);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 68);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSalary
            // 
            btnSalary.Font = new Font("Tahoma", 11.25F);
            btnSalary.Location = new Point(206, 443);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(86, 68);
            btnSalary.TabIndex = 27;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
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
            navbarLeft.TabIndex = 28;
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
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(navbarLeft);
            Controls.Add(btnSalary);
            Controls.Add(btnRemove);
            Controls.Add(btnBack);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnExport);
            Controls.Add(btnClockOut);
            Controls.Add(btnClockIn);
            Controls.Add(dgvAttendance);
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAttendance;
        private Button btnClockIn;
        private Button btnClockOut;
        private Button btnExport;
        private Button btnEdit;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Button btnBack;
        private Button btnRemove;
        private Button btnSalary;
        private MenuStrip navbarLeft;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
    }
}