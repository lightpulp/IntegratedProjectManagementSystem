using IntegratedProjectManagementSystem.Dashboard;
using IntegratedProjectManagementSystem.Inventory;
using IntegratedProjectManagementSystem.Resources;
using IntegratedProjectManagementSystem.Services;
using IntegratedProjectManagementSystem.Staff;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static IntegratedProjectManagementSystem.Services.ProjectService;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormClickProject : Form
    {
        private int _projectId;
        private ProjectService _projectService;

        public FormClickProject(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
            _projectService = new ProjectService();
            LoadProjectDetails();
            LoadProjectProducts();
            LoadProjectEmployees();
        }

        private void LoadProjectDetails()
        {
            try
            {
                var project = _projectService.GetProjectById(_projectId);
                if (project != null)
                {
                    // Display project details in your form controls
                    this.Text = $"Project: {project.ProjectName} - ID: {project.ProjectId}";

                    // Assign values to labels
                    lblProjectName.Text = project.ProjectName;
                    lblClientName.Text = project.ClientName;
                    lblStatus.Text = project.Status;
                    lblStatus.ForeColor = project.Status switch
                    {
                        "Initiated" => System.Drawing.Color.FromArgb(0, 128, 0),
                        "Quote Sent" => System.Drawing.Color.FromArgb(0, 102, 204),
                        "Ongoing" => System.Drawing.Color.Orange,
                        "Completed" => System.Drawing.Color.Purple,
                        "Canceled" => System.Drawing.Color.Red,
                    };
                    lblDateCompleted.Text = project.CompletedDate.ToString("MMM dd, yyyy");


                    lblProjectDescription.Text = project.ProjectDescription;
                    lblProjectType.Text = project.ProjectType;
                    lblProjectID.Text = project.ProjectId.ToString();
                    lblDeadline.Text = project.Deadline.ToString("MMM dd, yyyy");
                    lblClientContact.Text = project.ClientContact;
                    lblClientAddress.Text = project.ClientAddress;
                    lblClientEmail.Text = project.ClientEmail;
                    lblNotes.Text = project.ClientNotes;
                    lblDiscount.Text = project.Discount.ToString("N2");


                    lblTotalPrice.Text = project.TotalPrice.ToString("N2");

                    /// IF PROJECT = COMPLETED
                    lblCompleted.Visible = project.Status == "Completed";
                    lblDateCompleted.Visible = project.Status == "Completed";

                    bool isProjectEditable = project.Status != "Completed" && project.Status != "Canceled";

                    btnSelectProduct.Enabled = isProjectEditable;
                    btnRemoveProduct.Enabled = isProjectEditable;
                    btnSelectEmployee.Enabled = isProjectEditable;
                    btnRemoveEmployee.Enabled = isProjectEditable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            try
            {
                // Open FormCreateProject in edit mode
                FormCreateProject editForm = new FormCreateProject(_projectId);
                editForm.ShowDialog();

                LoadProjectDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening edit form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //////////////////////////////////////////// QUOTATION ////////////////////////////////////////////
        private void btnCreateQuotation_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Quotation";
                saveFileDialog.FileName = $"Quotation_{DateTime.Now:yyyyMMdd}" + lblClientName.Text + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    // Load project info

                    ProjectService projectService = new ProjectService();
                    var project = projectService.GetProjectById(_projectId);

                    // Load products for the project
                    DataTable productsTable = GetProjectProductsTable();

                    var document = Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(2, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(11));

                            // ---------------- HEADER ----------------
                            page.Header().Row(row =>
                            {
                                row.RelativeColumn().Column(col =>
                                {
                                    col.Item().Text("BETIS LEGACY FURNITURE")
                                        .Bold().FontSize(20);

                                    col.Item().Text("Address line 1");
                                    col.Item().Text("City, Country");
                                    col.Item().Text("Phone: +(63) 949 941 8521");
                                    col.Item().Text("Email: betislegacyfurniture@gmail.com");
                                });

                                row.ConstantColumn(120).Height(80).AlignRight()
                                .Image(BitmapToByteArray(IntegratedProjectManagementSystem.Properties.Resources.logo),
                                       ImageScaling.FitHeight);
                            });

                            page.Content().PaddingVertical(10).Column(col =>
                            {
                                col.Spacing(15);

                                // ---------------- TITLE ----------------
                                col.Item().Text("QUOTATION")
                                    .Bold().FontSize(24).FontColor(Colors.Blue.Medium);

                                // ---------------- CLIENT INFO ----------------
                                col.Item().BorderBottom(1).PaddingBottom(5).Text("Client Information")
                                    .Bold().FontSize(14);

                                col.Item().Column(info =>
                                {
                                    info.Item().Text($"Name: {project.ClientName}");
                                    info.Item().Text($"Contact: {project.ClientContact}");
                                    info.Item().Text($"Email: {project.ClientEmail}");
                                    info.Item().Text($"Address: {project.ClientAddress}");
                                });

                                // ---------------- PROJECT INFO ----------------
                                col.Item().PaddingTop(10).BorderBottom(1).PaddingBottom(5).Text("Project Details")
                                    .Bold().FontSize(14);

                                col.Item().Column(info =>
                                {
                                    info.Item().Text($"Project Name: {project.ProjectName}");
                                    info.Item().Text($"Type: {project.ProjectType}");
                                    info.Item().Text($"Description: {project.ProjectDescription}");
                                    info.Item().Text($"Deadline: {project.Deadline:MMMM dd, yyyy}");
                                    info.Item().Text($"Date Created: {project.DateCreated:MMMM dd, yyyy}");
                                });

                                // ---------------- PRODUCT TABLE ----------------
                                col.Item().PaddingTop(15).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(4);
                                        columns.RelativeColumn(2);
                                        columns.RelativeColumn(2);
                                        columns.RelativeColumn(2);
                                    });

                                    // Header Row
                                    table.Header(header =>
                                    {
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Product");
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Qty");
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Unit Price");
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Total");
                                    });

                                    // Rows
                                    decimal grandTotal = project.TotalPrice;

                                    foreach (DataRow row in productsTable.Rows)
                                    {
                                        string productName = row["ProductName"].ToString();
                                        int quantity = Convert.ToInt32(row["Quantity"]);
                                        decimal unitPrice = Convert.ToDecimal(row["SalePrice"]);
                                        decimal total = quantity * unitPrice;

                                        table.Cell().BorderBottom(1).Padding(5).Text(productName);
                                        table.Cell().BorderBottom(1).Padding(5).Text(quantity.ToString());
                                        table.Cell().BorderBottom(1).Padding(5).Text($"{unitPrice:C}");
                                        table.Cell().BorderBottom(1).Padding(5).Text($"{total:C}");
                                    }

                                    // Total / Discount / Grand Total
                                    decimal finalTotal = grandTotal - project.Discount;

                                    // Subtotal
                                    table.Cell().ColumnSpan(3).AlignRight().Padding(5).Text("Subtotal:").Bold();
                                    table.Cell().Padding(5).Text($"{grandTotal:C}");

                                    // Discount
                                    table.Cell().ColumnSpan(3).AlignRight().Padding(5).Text("Discount:").Bold();
                                    table.Cell().Padding(5).Text($"{project.Discount:C}");

                                    // Grand Total
                                    table.Cell().ColumnSpan(3).AlignRight().Padding(5).Text("Estimated Total:").Bold().FontSize(14);
                                    table.Cell().Padding(5).Text($"{finalTotal:C}").Bold().FontSize(14);
                                });


                                // ---------------- NOTES ----------------
                                col.Item().PaddingTop(20).Text("Notes")
                                    .Bold().FontSize(14);

                                col.Item().Text(project.ClientNotes);

                                // ---------------- SIGNATURE ----------------
                                col.Item().PaddingTop(50).Row(r =>
                                {
                                    r.RelativeColumn().AlignLeft().Text("______________________");
                                    r.RelativeColumn().AlignLeft().Text("Authorized Signature");
                                });
                            });

                            // ---------------- FOOTER ----------------
                            page.Footer().AlignCenter().Text(x =>
                            {
                                x.Span("Page ");
                                x.CurrentPageNumber();
                            });
                        });
                    });

                    document.GeneratePdf(saveFileDialog.FileName);

                    MessageBox.Show("Quotation PDF created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private DataTable GetProjectProductsTable()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(@"
            SELECT p.ProductName, pp.Quantity, p.SalePrice
            FROM ProjectProducts pp
            INNER JOIN Products p ON pp.ProductId = p.ProductId
            WHERE pp.ProjectId = @ProjectId
        ", conn);

                adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                adapter.Fill(dt);
            }
            return dt;
        }


        // Add this helper method inside the FormClickProject class (or as a static utility if preferred)
        private static byte[] BitmapToByteArray(Bitmap bitmap)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        //////////////////////////////////////////// INVOICE ////////////////////////////////////////////

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Invoice";
                saveFileDialog.FileName = $"Invoice_{DateTime.Now:yyyyMMdd}_{lblClientName.Text}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    // Load project info
                    ProjectService projectService = new ProjectService();
                    var project = projectService.GetProjectById(_projectId);

                    // Load products for the project
                    DataTable productsTable = GetProjectProductsTable();

                    // Calculate labor cost
                    decimal totalLaborCost = CalculateLaborCost(project);

                    // Calculate project duration in days
                    TimeSpan projectDuration = project.Deadline - project.DateCreated;
                    int totalProjectDays = Math.Max(1, (int)projectDuration.TotalDays);

                    // Calculate totals
                    decimal productsTotal = project.TotalPrice;
                    decimal laborPercentage = 0.8m; // 80% of calculated labor cost
                    decimal adjustedLaborCost = totalLaborCost * laborPercentage;
                    decimal subtotal = productsTotal + adjustedLaborCost;
                    decimal finalTotal = subtotal - project.Discount;

                    var document = Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(2, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(11));

                            // ---------------- HEADER ----------------
                            page.Header().Row(row =>
                            {
                                row.RelativeColumn().Column(col =>
                                {
                                    col.Item().Text("BETIS LEGACY FURNITURE")
                                        .Bold().FontSize(20);

                                    col.Item().Text("Address line 1");
                                    col.Item().Text("City, Country");
                                    col.Item().Text("Phone: +(63) 949 941 8521");
                                    col.Item().Text("Email: betislegacyfurniture@gmail.com");
                                });

                                row.ConstantColumn(120).Height(80).AlignRight()
                                .Image(BitmapToByteArray(IntegratedProjectManagementSystem.Properties.Resources.logo),
                                        ImageScaling.FitHeight);
                            });

                            page.Content().PaddingVertical(10).Column(col =>
                            {
                                col.Spacing(15);

                                // ---------------- TITLE ----------------
                                col.Item().Text("INVOICE")
                                    .Bold().FontSize(24).FontColor(Colors.Blue.Medium);

                                // ---------------- CLIENT INFO ----------------
                                col.Item().BorderBottom(1).PaddingBottom(5).Text("Bill To")
                                    .Bold().FontSize(14);

                                col.Item().Column(info =>
                                {
                                    info.Item().Text($"Name: {project.ClientName}");
                                    info.Item().Text($"Contact: {project.ClientContact}");
                                    info.Item().Text($"Email: {project.ClientEmail}");
                                    info.Item().Text($"Address: {project.ClientAddress}");
                                });

                                // ---------------- PROJECT INFO ----------------
                                col.Item().PaddingTop(10).BorderBottom(1).PaddingBottom(5).Text("Project Details")
                                    .Bold().FontSize(14);

                                col.Item().Column(info =>
                                {
                                    info.Item().Text($"Project Name: {project.ProjectName}");
                                    info.Item().Text($"Type: {project.ProjectType}");
                                    info.Item().Text($"Description: {project.ProjectDescription}");
                                    info.Item().Text($"Start Date: {project.DateCreated:MMMM dd, yyyy}");
                                    info.Item().Text($"Deadline: {project.Deadline:MMMM dd, yyyy}");
                                    info.Item().Text($"Duration: {totalProjectDays} days");
                                });

                                // ---------------- PRODUCTS TABLE ----------------
                                col.Item().PaddingTop(15).Text("Products & Services")
                                    .Bold().FontSize(14);

                                col.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(4);
                                        columns.RelativeColumn(2);
                                        columns.RelativeColumn(2);
                                        columns.RelativeColumn(2);
                                    });

                                    // Header Row
                                    table.Header(header =>
                                    {
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Description");
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Qty");
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Unit Price");
                                        header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Total");
                                    });

                                    // Product Rows
                                    foreach (DataRow row in productsTable.Rows)
                                    {
                                        string productName = row["ProductName"].ToString();
                                        int quantity = Convert.ToInt32(row["Quantity"]);
                                        decimal unitPrice = Convert.ToDecimal(row["SalePrice"]);
                                        decimal total = quantity * unitPrice;

                                        table.Cell().BorderBottom(1).Padding(5).Text(productName);
                                        table.Cell().BorderBottom(1).Padding(5).Text(quantity.ToString());
                                        table.Cell().BorderBottom(1).Padding(5).Text($"{unitPrice:C}");
                                        table.Cell().BorderBottom(1).Padding(5).Text($"{total:C}");
                                    }

                                    // Labor Cost Row
                                    table.Cell().BorderBottom(1).Padding(5).Text("Labor & Services");
                                    table.Cell().BorderBottom(1).Padding(5).Text($"{totalProjectDays} days");
                                    table.Cell().BorderBottom(1).Padding(5).Text($"{adjustedLaborCost / totalProjectDays:C}/day");
                                    table.Cell().BorderBottom(1).Padding(5).Text($"{adjustedLaborCost:C}");
                                });

                                // ---------------- SUMMARY TABLE ----------------
                                col.Item().PaddingTop(20).Table(summaryTable =>
                                {
                                    summaryTable.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(3);
                                        columns.RelativeColumn(1);
                                    });

                                    // Products Subtotal
                                    summaryTable.Cell().ColumnSpan(1).AlignRight().Padding(5).Text("Products Subtotal:");
                                    summaryTable.Cell().Padding(5).Text($"{productsTotal:C}");

                                    // Labor Cost
                                    summaryTable.Cell().ColumnSpan(1).AlignRight().Padding(5).Text("Labor & Services:");
                                    summaryTable.Cell().Padding(5).Text($"{adjustedLaborCost:C}");

                                    // Subtotal
                                    summaryTable.Cell().ColumnSpan(1).AlignRight().Padding(5).Text("Subtotal:").Bold();
                                    summaryTable.Cell().Padding(5).Text($"{subtotal:C}").Bold();

                                    // Discount
                                    summaryTable.Cell().ColumnSpan(1).AlignRight().Padding(5).Text("Discount:");
                                    summaryTable.Cell().Padding(5).Text($"-{project.Discount:C}");

                                    // Grand Total
                                    summaryTable.Cell().ColumnSpan(1).AlignRight().Padding(5).Text("Grand Total:").Bold().FontSize(14);
                                    summaryTable.Cell().Padding(5).Text($"{finalTotal:C}").Bold().FontSize(14);
                                });

                                // ---------------- PAYMENT TERMS ----------------
                                col.Item().PaddingTop(20).Text("Payment Terms")
                                    .Bold().FontSize(14);

                                col.Item().Column(terms =>
                                {
                                    terms.Item().Text("• 50% downpayment upon signing of contract");
                                    terms.Item().Text("• 50% balance upon project completion");
                                    terms.Item().Text("• Payment due within 15 days of invoice date");
                                });

                                // ---------------- NOTES ----------------
                                col.Item().PaddingTop(20).Text("Notes")
                                    .Bold().FontSize(14);

                                col.Item().Text(project.ClientNotes);

                                // ---------------- SIGNATURE ----------------
                                col.Item().PaddingTop(50).Row(r =>
                                {
                                    r.RelativeColumn().AlignLeft().Text("______________________");
                                    r.RelativeColumn().AlignLeft().Text("Authorized Signature");
                                });
                            });

                            // ---------------- FOOTER ----------------
                            page.Footer().AlignCenter().Text(x =>
                            {
                                x.Span("Page ");
                                x.CurrentPageNumber();
                            });
                        });
                    });

                    document.GeneratePdf(saveFileDialog.FileName);

                    MessageBox.Show("Invoice PDF created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private decimal CalculateLaborCost(ProjectService.Project project)
        {
            decimal totalLaborCost = 0;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Get all employees assigned to this project with their daily rates
                    string query = @"
                SELECT e.DailyRate
                FROM ProjectEmployees pe
                INNER JOIN Employees e ON pe.EmployeeId = e.EmployeeId
                WHERE pe.ProjectId = @ProjectId AND e.Active = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", _projectId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal dailyRate = reader.GetDecimal("DailyRate");
                                totalLaborCost += dailyRate;
                            }
                        }
                    }

                    // Calculate project duration in days
                    TimeSpan projectDuration = project.Deadline - project.DateCreated;
                    int totalProjectDays = Math.Max(1, (int)projectDuration.TotalDays);

                    // Total labor cost = sum of all employee daily rates × project duration
                    totalLaborCost *= totalProjectDays;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating labor cost: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalLaborCost;
        }

        //////////////////////////////////////////// PROJECT PRODUCTS ////////////////////////////////////////////

        private void LoadProjectProducts()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT pp.ProjectProductId, pp.Quantity, 
                       p.ProductName, p.Description, p.Category, p.Dimension, p.SalePrice,
                       (pp.Quantity * p.SalePrice) as TotalPrice
                FROM ProjectProducts pp
                INNER JOIN Products p ON pp.ProductId = p.ProductId
                WHERE pp.ProjectId = @ProjectId
                ORDER BY p.ProductName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProjectProductList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            FormClickProject_AddProduct addProductForm = new FormClickProject_AddProduct(_projectId);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                LoadProjectProducts();
                LoadProjectDetails();
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvProjectProductList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to remove.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove this product from the project?",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int projectProductId = Convert.ToInt32(dgvProjectProductList.SelectedRows[0].Cells["ProjectProductId"].Value);
                    decimal itemTotal = Convert.ToDecimal(dgvProjectProductList.SelectedRows[0].Cells["TotalPrice"].Value);

                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Start transaction to ensure both operations succeed
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // 1. Delete from ProjectProducts
                                string deleteQuery = "DELETE FROM ProjectProducts WHERE ProjectProductId = @ProjectProductId";
                                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ProjectProductId", projectProductId);
                                    cmd.ExecuteNonQuery();
                                }

                                // 2. Update Project TotalPrice (deduct the amount)
                                string updateQuery = @"
                            UPDATE Projects 
                            SET TotalPrice = ISNULL(TotalPrice, 0) - @ItemTotal
                            WHERE ProjectId = @ProjectId";

                                using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ItemTotal", itemTotal);
                                    cmd.Parameters.AddWithValue("@ProjectId", _projectId);
                                    cmd.ExecuteNonQuery();
                                }

                                // Commit transaction
                                transaction.Commit();

                                LoadProjectProducts(); // Refresh the list
                                LoadProjectDetails(); // Refresh project details to show updated total
                                MessageBox.Show("Product removed successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing product: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        //////////////////////////////////////////// PROJECT EMPLOYEES ////////////////////////////////////////////

        private void LoadProjectEmployees()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT pe.ProjectEmployeeId, pe.HoursWorked, pe.AssignmentDate, pe.Notes,
                       e.FirstName, e.LastName, e.Position, e.DailyRate,
                       (pe.HoursWorked * e.DailyRate / 8) as LaborCost -- Assuming 8-hour work day
                FROM ProjectEmployees pe
                INNER JOIN Employees e ON pe.EmployeeId = e.EmployeeId
                WHERE pe.ProjectId = @ProjectId
                ORDER BY pe.AssignmentDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProjectEmployeeList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project employees: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            FormClickProject_AddEmployee addEmployeeForm = new FormClickProject_AddEmployee(_projectId);
            if (addEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                LoadProjectEmployees(); // Refresh the employee list
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvProjectEmployeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to remove.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove this employee from the project?",
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int projectEmployeeId = Convert.ToInt32(dgvProjectEmployeeList.SelectedRows[0].Cells["ProjectEmployeeId"].Value);

                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM ProjectEmployees WHERE ProjectEmployeeId = @ProjectEmployeeId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProjectEmployeeId", projectEmployeeId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadProjectEmployees(); // Refresh the list
                    MessageBox.Show("Employee removed successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing employee: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //////////////////////////////////////////// NAVIGATION ////////////////////////////////////////////
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormProject>(this);
        }


    }
}