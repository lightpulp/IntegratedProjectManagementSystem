namespace IntegratedProjectManagementSystem.Dashboard
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            pnlDashboard = new Panel();
            panel3 = new Panel();
            chartConversionRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            panel2 = new Panel();
            chartTopUsedMaterials = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            panel1 = new Panel();
            pnlProjectAnalytics = new Panel();
            chartProjectHealth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            pnlQuickActions = new Panel();
            btnCreateMaterial = new Button();
            btnCreateProduct = new Button();
            btnCreateProject = new Button();
            lblQuickActions = new Label();
            pnlProjectStatus = new Panel();
            chartProfitMargin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblProfit = new Label();
            pnlLowStock = new Panel();
            dgvLowStock = new DataGridView();
            lblLowStock = new Label();
            pnlUpcomingDeadlines = new Panel();
            dgvUpcomingDeadlines = new DataGridView();
            lblUpcomingDeadlines = new Label();
            pnlKPI = new Panel();
            lblRevenue = new Label();
            lbl = new Label();
            lblCompletedProjects = new Label();
            lblCompleted = new Label();
            lblActiveProjects = new Label();
            lblActive = new Label();
            lblTotalProjects = new Label();
            lblProjects = new Label();
            navbarLeft = new MenuStrip();
            btnDashboard = new ToolStripMenuItem();
            btnProjects = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnStaff = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pnlDashboard.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartConversionRate).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopUsedMaterials).BeginInit();
            pnlProjectAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProjectHealth).BeginInit();
            pnlQuickActions.SuspendLayout();
            pnlProjectStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProfitMargin).BeginInit();
            pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            pnlUpcomingDeadlines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingDeadlines).BeginInit();
            pnlKPI.SuspendLayout();
            navbarLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.AutoScroll = true;
            pnlDashboard.Controls.Add(panel3);
            pnlDashboard.Controls.Add(panel2);
            pnlDashboard.Controls.Add(panel1);
            pnlDashboard.Controls.Add(pnlProjectAnalytics);
            pnlDashboard.Controls.Add(pnlQuickActions);
            pnlDashboard.Controls.Add(pnlProjectStatus);
            pnlDashboard.Controls.Add(pnlLowStock);
            pnlDashboard.Controls.Add(pnlUpcomingDeadlines);
            pnlDashboard.Controls.Add(pnlKPI);
            pnlDashboard.Location = new Point(184, 12);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(998, 546);
            pnlDashboard.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(chartConversionRate);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(15, 686);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 222);
            panel3.TabIndex = 8;
            // 
            // chartConversionRate
            // 
            chartArea1.Name = "ChartArea1";
            chartConversionRate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartConversionRate.Legends.Add(legend1);
            chartConversionRate.Location = new Point(23, 43);
            chartConversionRate.Name = "chartConversionRate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Projects";
            chartConversionRate.Series.Add(series1);
            chartConversionRate.Size = new Size(393, 164);
            chartConversionRate.TabIndex = 3;
            chartConversionRate.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label3.Location = new Point(15, 10);
            label3.Name = "label3";
            label3.Size = new Size(122, 17);
            label3.TabIndex = 2;
            label3.Text = "Conversion Rate";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(chartTopUsedMaterials);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(490, 536);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 231);
            panel2.TabIndex = 8;
            // 
            // chartTopUsedMaterials
            // 
            chartArea2.Name = "ChartArea1";
            chartTopUsedMaterials.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTopUsedMaterials.Legends.Add(legend2);
            chartTopUsedMaterials.Location = new Point(15, 42);
            chartTopUsedMaterials.Name = "chartTopUsedMaterials";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Usage";
            chartTopUsedMaterials.Series.Add(series2);
            chartTopUsedMaterials.Size = new Size(458, 170);
            chartTopUsedMaterials.TabIndex = 3;
            chartTopUsedMaterials.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 2;
            label2.Text = "Inventory Insights";
            // 
            // panel1
            // 
            panel1.Location = new Point(471, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 503);
            panel1.TabIndex = 8;
            // 
            // pnlProjectAnalytics
            // 
            pnlProjectAnalytics.BackColor = Color.White;
            pnlProjectAnalytics.BorderStyle = BorderStyle.FixedSingle;
            pnlProjectAnalytics.Controls.Add(chartProjectHealth);
            pnlProjectAnalytics.Controls.Add(label1);
            pnlProjectAnalytics.Location = new Point(15, 442);
            pnlProjectAnalytics.Name = "pnlProjectAnalytics";
            pnlProjectAnalytics.Size = new Size(450, 231);
            pnlProjectAnalytics.TabIndex = 7;
            // 
            // chartProjectHealth
            // 
            chartArea3.Name = "ChartArea1";
            chartProjectHealth.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartProjectHealth.Legends.Add(legend3);
            chartProjectHealth.Location = new Point(23, 43);
            chartProjectHealth.Name = "chartProjectHealth";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Status";
            chartProjectHealth.Series.Add(series3);
            chartProjectHealth.Size = new Size(329, 164);
            chartProjectHealth.TabIndex = 3;
            chartProjectHealth.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 2;
            label1.Text = "Project Analytics";
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.BackColor = Color.White;
            pnlQuickActions.BorderStyle = BorderStyle.FixedSingle;
            pnlQuickActions.Controls.Add(btnCreateMaterial);
            pnlQuickActions.Controls.Add(btnCreateProduct);
            pnlQuickActions.Controls.Add(btnCreateProject);
            pnlQuickActions.Controls.Add(lblQuickActions);
            pnlQuickActions.Location = new Point(15, 319);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new Size(450, 107);
            pnlQuickActions.TabIndex = 6;
            // 
            // btnCreateMaterial
            // 
            btnCreateMaterial.Font = new Font("Tahoma", 9F);
            btnCreateMaterial.Location = new Point(285, 49);
            btnCreateMaterial.Name = "btnCreateMaterial";
            btnCreateMaterial.Size = new Size(120, 36);
            btnCreateMaterial.TabIndex = 3;
            btnCreateMaterial.Text = "Create Material";
            btnCreateMaterial.UseVisualStyleBackColor = true;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Font = new Font("Tahoma", 9F);
            btnCreateProduct.Location = new Point(155, 49);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(120, 36);
            btnCreateProduct.TabIndex = 2;
            btnCreateProduct.Text = "Create Product";
            btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // btnCreateProject
            // 
            btnCreateProject.Font = new Font("Tahoma", 9F);
            btnCreateProject.Location = new Point(25, 49);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(120, 36);
            btnCreateProject.TabIndex = 1;
            btnCreateProject.Text = "Create Project";
            btnCreateProject.UseVisualStyleBackColor = true;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblQuickActions.Location = new Point(15, 15);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(101, 17);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // pnlProjectStatus
            // 
            pnlProjectStatus.BackColor = Color.White;
            pnlProjectStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlProjectStatus.Controls.Add(chartProfitMargin);
            pnlProjectStatus.Controls.Add(lblProfit);
            pnlProjectStatus.Location = new Point(490, 319);
            pnlProjectStatus.Name = "pnlProjectStatus";
            pnlProjectStatus.Size = new Size(488, 200);
            pnlProjectStatus.TabIndex = 5;
            // 
            // chartProfitMargin
            // 
            chartArea4.Name = "ChartArea1";
            chartProfitMargin.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartProfitMargin.Legends.Add(legend4);
            chartProfitMargin.Location = new Point(14, 37);
            chartProfitMargin.Name = "chartProfitMargin";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "ProfitMargin";
            chartProfitMargin.Series.Add(series4);
            chartProfitMargin.Size = new Size(458, 147);
            chartProfitMargin.TabIndex = 4;
            chartProfitMargin.Text = "chart1";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblProfit.Location = new Point(15, 15);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(97, 17);
            lblProfit.TabIndex = 0;
            lblProfit.Text = "Profit Margin";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(dgvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Location = new Point(490, 110);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(488, 200);
            pnlLowStock.TabIndex = 3;
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Location = new Point(15, 45);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.Size = new Size(458, 140);
            dgvLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblLowStock.Location = new Point(15, 15);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(117, 17);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock Alert";
            // 
            // pnlUpcomingDeadlines
            // 
            pnlUpcomingDeadlines.BackColor = Color.White;
            pnlUpcomingDeadlines.BorderStyle = BorderStyle.FixedSingle;
            pnlUpcomingDeadlines.Controls.Add(dgvUpcomingDeadlines);
            pnlUpcomingDeadlines.Controls.Add(lblUpcomingDeadlines);
            pnlUpcomingDeadlines.Location = new Point(15, 110);
            pnlUpcomingDeadlines.Name = "pnlUpcomingDeadlines";
            pnlUpcomingDeadlines.Size = new Size(450, 200);
            pnlUpcomingDeadlines.TabIndex = 1;
            // 
            // dgvUpcomingDeadlines
            // 
            dgvUpcomingDeadlines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcomingDeadlines.Location = new Point(15, 45);
            dgvUpcomingDeadlines.Name = "dgvUpcomingDeadlines";
            dgvUpcomingDeadlines.Size = new Size(420, 140);
            dgvUpcomingDeadlines.TabIndex = 1;
            // 
            // lblUpcomingDeadlines
            // 
            lblUpcomingDeadlines.AutoSize = true;
            lblUpcomingDeadlines.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            lblUpcomingDeadlines.Location = new Point(15, 15);
            lblUpcomingDeadlines.Name = "lblUpcomingDeadlines";
            lblUpcomingDeadlines.Size = new Size(146, 17);
            lblUpcomingDeadlines.TabIndex = 0;
            lblUpcomingDeadlines.Text = "Upcoming Deadlines";
            // 
            // pnlKPI
            // 
            pnlKPI.BackColor = Color.White;
            pnlKPI.BorderStyle = BorderStyle.FixedSingle;
            pnlKPI.Controls.Add(lblRevenue);
            pnlKPI.Controls.Add(lbl);
            pnlKPI.Controls.Add(lblCompletedProjects);
            pnlKPI.Controls.Add(lblCompleted);
            pnlKPI.Controls.Add(lblActiveProjects);
            pnlKPI.Controls.Add(lblActive);
            pnlKPI.Controls.Add(lblTotalProjects);
            pnlKPI.Controls.Add(lblProjects);
            pnlKPI.Location = new Point(15, 15);
            pnlKPI.Name = "pnlKPI";
            pnlKPI.Size = new Size(963, 80);
            pnlKPI.TabIndex = 0;
            // 
            // lblRevenue
            // 
            lblRevenue.AutoSize = true;
            lblRevenue.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblRevenue.ForeColor = Color.OrangeRed;
            lblRevenue.Location = new Point(480, 35);
            lblRevenue.Name = "lblRevenue";
            lblRevenue.Size = new Size(64, 23);
            lblRevenue.TabIndex = 7;
            lblRevenue.Text = "₱0.00";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lbl.Location = new Point(480, 15);
            lbl.Name = "lbl";
            lbl.Size = new Size(193, 14);
            lbl.TabIndex = 6;
            lbl.Text = "Expected Revenue This Month";
            // 
            // lblCompletedProjects
            // 
            lblCompletedProjects.AutoSize = true;
            lblCompletedProjects.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblCompletedProjects.ForeColor = Color.Purple;
            lblCompletedProjects.Location = new Point(300, 35);
            lblCompletedProjects.Name = "lblCompletedProjects";
            lblCompletedProjects.Size = new Size(22, 23);
            lblCompletedProjects.TabIndex = 5;
            lblCompletedProjects.Text = "0";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblCompleted.Location = new Point(300, 15);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(127, 14);
            lblCompleted.TabIndex = 4;
            lblCompleted.Text = "Completed Projects";
            // 
            // lblActiveProjects
            // 
            lblActiveProjects.AutoSize = true;
            lblActiveProjects.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblActiveProjects.ForeColor = Color.Green;
            lblActiveProjects.Location = new Point(150, 35);
            lblActiveProjects.Name = "lblActiveProjects";
            lblActiveProjects.Size = new Size(22, 23);
            lblActiveProjects.TabIndex = 3;
            lblActiveProjects.Text = "0";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblActive.Location = new Point(150, 15);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(99, 14);
            lblActive.TabIndex = 2;
            lblActive.Text = "Active Projects";
            // 
            // lblTotalProjects
            // 
            lblTotalProjects.AutoSize = true;
            lblTotalProjects.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblTotalProjects.ForeColor = Color.DodgerBlue;
            lblTotalProjects.Location = new Point(20, 35);
            lblTotalProjects.Name = "lblTotalProjects";
            lblTotalProjects.Size = new Size(22, 23);
            lblTotalProjects.TabIndex = 1;
            lblTotalProjects.Text = "0";
            // 
            // lblProjects
            // 
            lblProjects.AutoSize = true;
            lblProjects.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblProjects.Location = new Point(20, 15);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(92, 14);
            lblProjects.TabIndex = 0;
            lblProjects.Text = "Total Projects";
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
            navbarLeft.TabIndex = 17;
            navbarLeft.Text = "menuStrip1";
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(173, 19);
            toolStripMenuItem1.Text = " ";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1184, 561);
            Controls.Add(navbarLeft);
            Controls.Add(pnlDashboard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            pnlDashboard.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartConversionRate).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTopUsedMaterials).EndInit();
            pnlProjectAnalytics.ResumeLayout(false);
            pnlProjectAnalytics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProjectHealth).EndInit();
            pnlQuickActions.ResumeLayout(false);
            pnlQuickActions.PerformLayout();
            pnlProjectStatus.ResumeLayout(false);
            pnlProjectStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProfitMargin).EndInit();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            pnlUpcomingDeadlines.ResumeLayout(false);
            pnlUpcomingDeadlines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcomingDeadlines).EndInit();
            pnlKPI.ResumeLayout(false);
            pnlKPI.PerformLayout();
            navbarLeft.ResumeLayout(false);
            navbarLeft.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem iNVENTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTAFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private Panel pnlDashboard;
        private Panel pnlKPI;
        private Label lblRevenue;
        private Label lbl;
        private Label lblCompletedProjects;
        private Label lblCompleted;
        private Label lblActiveProjects;
        private Label lblActive;
        private Label lblTotalProjects;
        private Label lblProjects;
        private Panel pnlUpcomingDeadlines;
        private DataGridView dgvUpcomingDeadlines;
        private Label lblUpcomingDeadlines;
        private Panel pnlLowStock;
        private DataGridView dgvLowStock;
        private Label lblLowStock;
        private Panel pnlProjectStatus;
        private Label lblProfit;
        private Panel pnlQuickActions;
        private Button btnCreateMaterial;
        private Button btnCreateProduct;
        private Button btnCreateProject;
        private Label lblQuickActions;
        private MenuStrip navbarLeft;
        private ToolStripMenuItem btnDashboard;
        private ToolStripMenuItem btnProjects;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnStaff;
        private ToolStripMenuItem btnLogout;
        private Panel panel1;
        private Panel pnlProjectAnalytics;
        private Label label1;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsedMaterials;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProjectHealth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfitMargin;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConversionRate;
        private Label label3;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}