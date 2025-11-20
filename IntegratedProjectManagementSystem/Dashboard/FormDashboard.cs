using IntegratedProjectManagementSystem.Inventory;
using IntegratedProjectManagementSystem.Projects;
using IntegratedProjectManagementSystem.Resources;
using IntegratedProjectManagementSystem.Services;
using IntegratedProjectManagementSystem.Staff;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Dashboard
{
    public partial class FormDashboard : Form
    {
        private DashboardService _dashboardService;

        public FormDashboard()
        {
            InitializeComponent();
            _dashboardService = new DashboardService();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Load Statistics
                LoadStatistics();

                // Load Charts
                LoadProjectHealthChart();
                LoadTopUsedMaterialsChart();
                LoadConversionRateChart();

                /*
                LoadProfitMarginChart();
                */

                // Load DataGridViews
                LoadLowStockGrid();
                LoadUpcomingDeadlinesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatistics()
        {
            var stats = _dashboardService.GetDashboardStats();

            lblTotalProjects.Text = stats.TotalProjects.ToString();
            lblActiveProjects.Text = stats.ActiveProjects.ToString();
            lblCompletedProjects.Text = stats.CompletedProjects.ToString();
            lblRevenue.Text = $"₱{stats.Revenue:N2}";
        }

        private void LoadProjectHealthChart()
        {
            chartProjectHealth.Series["Status"].Points.Clear();
            var statusCounts = _dashboardService.GetProjectStatusCounts();

            foreach (var status in statusCounts)
            {
                chartProjectHealth.Series["Status"].Points.AddXY(status.Status, status.Count);
            }
        }

        private void LoadTopUsedMaterialsChart()
        {
            chartTopUsedMaterials.Series["Usage"].Points.Clear();
            var topMaterials = _dashboardService.GetTopUsedMaterials(8);

            foreach (var material in topMaterials)
            {
                chartTopUsedMaterials.Series["Usage"].Points.AddXY(material.MaterialName, material.UsageCount);
            }
        }

        private void LoadConversionRateChart()
        {
            chartConversionRate.Series["Projects"].Points.Clear();
            var conversion = _dashboardService.GetConversionRate();

            chartConversionRate.Series["Projects"].Points.AddXY("Received", conversion.ReceivedProjects);
            chartConversionRate.Series["Projects"].Points.AddXY("Completed", conversion.CompletedProjects);
        }

        private void LoadLowStockGrid()
        {
            var lowStock = _dashboardService.GetLowStockItems();
            dgvLowStock.DataSource = lowStock;
        }

        private void LoadUpcomingDeadlinesGrid()
        {
            var deadlines = _dashboardService.GetUpcomingDeadlines();
            dgvUpcomingDeadlines.DataSource = deadlines;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormDashboard>(this);
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormInventory>(this);
        }
        private void btnProjects_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormProject>(this);

        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormStaff>(this);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            HelperNavigation.ReturnToLogin(this);
        }

        /*
        private void LoadProfitMarginChart()
        {
            // Make sure the series exists
            if (chartProfitMargin.Series.IndexOf("ProfitMargin") == -1)
            {
                var series = chartProfitMargin.Series.Add("ProfitMargin");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                series.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }

            chartProfitMargin.Series["ProfitMargin"].Points.Clear();
            chartProfitMargin.Titles.Clear();
            chartProfitMargin.Titles.Add("Project Profit Margins (%)");

            var profitMargins = _dashboardService.GetProfitMarginData();

            foreach (var project in profitMargins.Take(10)) // Show top 10 projects
            {
                var dataPoint = chartProfitMargin.Series["ProfitMargin"].Points.Add(Convert.ToDouble(project.ProfitMarginPercent));
                dataPoint.AxisLabel = project.ProjectName;
                dataPoint.Label = $"{project.ProfitMarginPercent}%";

                // Color coding based on profit margin
                if (project.ProfitMarginPercent >= 30)
                    dataPoint.Color = Color.Green;
                else if (project.ProfitMarginPercent >= 15)
                    dataPoint.Color = Color.Orange;
                else
                    dataPoint.Color = Color.Red;
            }

            // Adjust Y-axis to show percentages properly
            chartProfitMargin.ChartAreas[0].AxisY.Title = "Profit Margin %";
            chartProfitMargin.ChartAreas[0].AxisY.Minimum = 0;
            chartProfitMargin.ChartAreas[0].AxisY.Maximum = 100;
        }
        */
    }
}