using IntegratedProjectManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Services
{
    public class DashboardService
    {
        public class DashboardStats
        {
            public int TotalProjects { get; set; }
            public int ActiveProjects { get; set; }
            public int CompletedProjects { get; set; }
            public decimal Revenue { get; set; }
        }

        public class ProjectStatusCount
        {
            public string Status { get; set; }
            public int Count { get; set; }
        }

        public class MaterialUsage
        {
            public string MaterialName { get; set; }
            public int UsageCount { get; set; }
        }

        public class ConversionRate
        {
            public int ReceivedProjects { get; set; }
            public int CompletedProjects { get; set; }
        }

        public class ProfitMargin
        {
            public string ProjectName { get; set; }
            public decimal ProfitMarginPercent { get; set; }
        }

        public class LowStockItem
        {
            public string MaterialName { get; set; }
            public decimal CurrentStock { get; set; }
            public string UnitOfMeasure { get; set; }
        }

        public class UpcomingDeadline
        {
            public string ProjectName { get; set; }
            public DateTime Deadline { get; set; }
            public string ClientName { get; set; }
        }

        public class ProfitMarginData
        {
            public string ProjectName { get; set; }
            public decimal ProfitMarginPercent { get; set; }
            public decimal Revenue { get; set; }
            public decimal Cost { get; set; }
        }

        public class ProductRequest
        {
            public string ProductName { get; set; }
            public int RequestCount { get; set; }
            public decimal TotalRevenue { get; set; }
        }

        public List<ProductRequest> GetTopRequestedProducts(int topCount = 8)
        {
            var products = new List<ProductRequest>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT TOP (@TopCount) 
                p.ProductName,
                COUNT(pp.ProjectProductId) as RequestCount,
                SUM(pp.Quantity * p.SalePrice) as TotalRevenue
            FROM ProjectProducts pp
            INNER JOIN Products p ON pp.ProductId = p.ProductId
            INNER JOIN Projects pr ON pp.ProjectId = pr.ProjectId
            WHERE p.IsActive = 1
            GROUP BY p.ProductId, p.ProductName
            ORDER BY RequestCount DESC, TotalRevenue DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TopCount", topCount);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new ProductRequest
                            {
                                ProductName = reader.GetString("ProductName"),
                                RequestCount = reader.GetInt32("RequestCount"),
                                TotalRevenue = reader.GetDecimal("TotalRevenue")
                            });
                        }
                    }
                }
            }

            return products;
        }

        // Get Dashboard Statistics
        public DashboardStats GetDashboardStats()
        {
            var stats = new DashboardStats();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        COUNT(*) as TotalProjects,
                        SUM(CASE WHEN Status NOT IN ('Completed', 'Canceled') THEN 1 ELSE 0 END) as ActiveProjects,
                        SUM(CASE WHEN Status = 'Completed' THEN 1 ELSE 0 END) as CompletedProjects,
                        ISNULL(SUM(TotalPrice), 0) as Revenue
                    FROM Projects";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        stats.TotalProjects = reader.GetInt32("TotalProjects");
                        stats.ActiveProjects = reader.GetInt32("ActiveProjects");
                        stats.CompletedProjects = reader.GetInt32("CompletedProjects");
                        stats.Revenue = reader.GetDecimal("Revenue");
                    }
                }
            }

            return stats;
        }

        // Get Project Status Distribution
        public List<ProjectStatusCount> GetProjectStatusCounts()
        {
            var statusCounts = new List<ProjectStatusCount>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT Status, COUNT(*) as Count
                    FROM Projects
                    GROUP BY Status
                    ORDER BY Count DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statusCounts.Add(new ProjectStatusCount
                        {
                            Status = reader.GetString("Status"),
                            Count = reader.GetInt32("Count")
                        });
                    }
                }
            }

            return statusCounts;
        }

        // Get Top Used Materials
        public List<MaterialUsage> GetTopUsedMaterials(int topCount = 10)
        {
            var materials = new List<MaterialUsage>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT TOP (@TopCount) m.MaterialName, COUNT(pm.ProductMaterialId) as UsageCount
                    FROM ProductMaterials pm
                    INNER JOIN Materials m ON pm.MaterialId = m.MaterialId
                    GROUP BY m.MaterialName
                    ORDER BY UsageCount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TopCount", topCount);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            materials.Add(new MaterialUsage
                            {
                                MaterialName = reader.GetString("MaterialName"),
                                UsageCount = reader.GetInt32("UsageCount")
                            });
                        }
                    }
                }
            }

            return materials;
        }

        // Get Conversion Rate (Last 30 days)
        public ConversionRate GetConversionRate()
        {
            var conversion = new ConversionRate();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        SUM(CASE WHEN DateCreated >= DATEADD(day, -30, GETDATE()) THEN 1 ELSE 0 END) as ReceivedProjects,
                        SUM(CASE WHEN Status = 'Completed' AND CompletedDate >= DATEADD(day, -30, GETDATE()) THEN 1 ELSE 0 END) as CompletedProjects
                    FROM Projects";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        conversion.ReceivedProjects = reader.GetInt32("ReceivedProjects");
                        conversion.CompletedProjects = reader.GetInt32("CompletedProjects");
                    }
                }
            }

            return conversion;
        }

        // Get Low Stock Items
        public List<LowStockItem> GetLowStockItems(decimal threshold = 50)
        {
            var lowStock = new List<LowStockItem>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT MaterialName, CurrentStock, UnitOfMeasure
                    FROM Materials
                    WHERE CurrentStock <= @Threshold AND IsActive = 1
                    ORDER BY CurrentStock ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Threshold", threshold);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lowStock.Add(new LowStockItem
                            {
                                MaterialName = reader.GetString("MaterialName"),
                                CurrentStock = reader.GetDecimal("CurrentStock"),
                                UnitOfMeasure = reader.GetString("UnitOfMeasure")
                            });
                        }
                    }
                }
            }

            return lowStock;
        }

        // Get Upcoming Deadlines (Next 30 days)
        public List<UpcomingDeadline> GetUpcomingDeadlines(int daysAhead = 30)
        {
            var deadlines = new List<UpcomingDeadline>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT ProjectName, Deadline, ClientName
                    FROM Projects
                    WHERE Deadline BETWEEN GETDATE() AND DATEADD(day, @DaysAhead, GETDATE())
                    AND Status NOT IN ('Completed', 'Canceled')
                    ORDER BY Deadline ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DaysAhead", daysAhead);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            deadlines.Add(new UpcomingDeadline
                            {
                                ProjectName = reader.GetString("ProjectName"),
                                Deadline = reader.GetDateTime("Deadline"),
                                ClientName = reader.GetString("ClientName")
                            });
                        }
                    }
                }
            }

            return deadlines;
        }

        // Get Profit Margin Data for Completed Projects


        public List<ProfitMarginData> GetProfitMarginData()
        {
            var profitMargins = new List<ProfitMarginData>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // This is a simplified calculation - you might need to adjust based on your actual cost structure
                string query = @"
            SELECT 
                p.ProjectName,
                p.TotalPrice as Revenue,
                ISNULL((
                    SELECT SUM(pm.QuantityRequired * m.UnitCost)
                    FROM ProjectProducts pp
                    INNER JOIN ProductMaterials pm ON pp.ProductId = pm.ProductId
                    INNER JOIN Materials m ON pm.MaterialId = m.MaterialId
                    WHERE pp.ProjectId = p.ProjectId
                ), 0) as MaterialCost,
                ISNULL((
                    SELECT SUM(pe.HoursWorked * e.DailyRate / 8) -- Assuming 8-hour work day
                    FROM ProjectEmployees pe
                    INNER JOIN Employees e ON pe.EmployeeId = e.EmployeeId
                    WHERE pe.ProjectId = p.ProjectId
                ), 0) as LaborCost
            FROM Projects p
            WHERE p.Status = 'Completed' AND p.TotalPrice > 0
            ORDER BY p.CompletedDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal revenue = reader.GetDecimal("Revenue");
                        decimal materialCost = reader.GetDecimal("MaterialCost");
                        decimal laborCost = reader.GetDecimal("LaborCost");
                        decimal totalCost = materialCost + laborCost;

                        decimal profitMargin = 0;
                        if (revenue > 0)
                        {
                            profitMargin = ((revenue - totalCost) / revenue) * 100;
                        }

                        profitMargins.Add(new ProfitMarginData
                        {
                            ProjectName = reader.GetString("ProjectName"),
                            ProfitMarginPercent = Math.Round(profitMargin, 2),
                            Revenue = revenue,
                            Cost = totalCost
                        });
                    }
                }
            }

            return profitMargins;
        }
    }
}