using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class SalaryForm : Form
    {
        private readonly string connectionString =
        @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;
          Initial Catalog=BLFDB;
          Integrated Security=True;
          TrustServerCertificate=True;";

        public SalaryForm()
        {
            InitializeComponent();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            LoadClockedOutEmployees();
        }

        private void LoadClockedOutEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    A.AttendanceId,
                    A.EmployeeId,
                    E.FirstName + ' ' + E.LastName AS FullName,
                    A.TimeIn,
                    A.TimeOut,
                    E.DailyRate,
                    E.EmployeePhoto
                FROM Attendance A
                JOIN Employees E ON A.EmployeeId = E.EmployeeId
                WHERE A.TimeOut IS NOT NULL";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    string fullName = reader["FullName"].ToString();

                    DateTime timeIn = Convert.ToDateTime(reader["TimeIn"]);
                    DateTime timeOut = Convert.ToDateTime(reader["TimeOut"]);
                    decimal dailyRate = Convert.ToDecimal(reader["DailyRate"]);

                    byte[] photoBytes = reader["EmployeePhoto"] as byte[];

                    // Calculations
                    decimal hourlyRate = dailyRate / 8;
                    TimeSpan span = timeOut - timeIn;
                    double hoursWorked = span.TotalHours;
                    decimal totalSalary = hourlyRate * (decimal)hoursWorked;

                    // Create card container
                    Panel card = new Panel();
                    card.Width = 500;
                    card.Height = 180;
                    card.BackColor = Color.White;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Margin = new Padding(10);
                    card.Padding = new Padding(10);

                    // Rounded PictureBox
                    PictureBox pic = new PictureBox();
                    pic.Width = 120;
                    pic.Height = 120;
                    pic.Left = 15;
                    pic.Top = 15;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;

                    // Load photo or fallback
                    if (photoBytes != null && photoBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(photoBytes))
                        {
                            pic.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Fallback built-in icon
                        pic.Image = SystemIcons.Information.ToBitmap();
                    }

                    // Make it ROUND
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1);
                    pic.Region = new Region(gp);

                    // Info labels container
                    Panel info = new Panel();
                    info.Left = 150;
                    info.Width = 330;
                    info.Height = 150;
                    info.Top = 15;

                    Label lblInfo = new Label();
                    lblInfo.AutoSize = true;
                    lblInfo.Font = new Font("Segoe UI", 10);
                    lblInfo.Text =
                        $"Name: {fullName}\n\n" +
                        $"Daily Rate: ₱{dailyRate:F2}\n" +
                        $"Hourly Rate: ₱{hourlyRate:F2}\n" +
                        $"Hours Worked: {hoursWorked:F2}\n\n" +
                        $"Total Salary: ₱{totalSalary:F2}";

                    lblInfo.ForeColor = Color.Black;

                    info.Controls.Add(lblInfo);
                    card.Controls.Add(info);
                    card.Controls.Add(pic);

                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }
    }
}
