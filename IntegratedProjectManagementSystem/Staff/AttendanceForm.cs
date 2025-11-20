using IntegratedProjectManagementSystem.Dashboard;
using IntegratedProjectManagementSystem.Inventory;
using IntegratedProjectManagementSystem.Projects;
using IntegratedProjectManagementSystem.Resources;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class AttendanceForm : Form
    {
        private System.Windows.Forms.Timer refreshTimer;

        private DateTime lastDate = DateTime.Now.Date;

        private readonly string connectionString =
        @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;
          Initial Catalog=BLFDB;
          Integrated Security=True;
          TrustServerCertificate=True;";

        public AttendanceForm()
        {
            InitializeComponent();

            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;

            LoadAttendanceDataByDate();  // Load today's records
            FormatAttendanceGrid();

            // Create working timer
            refreshTimer = new System.Windows.Forms.Timer();

            refreshTimer.Interval = 5000; // every 5 seconds
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Detect date change
            if (DateTime.Now.Date != lastDate)
            {
                lastDate = DateTime.Now.Date;
                dateTimePicker.Value = lastDate; // switch calendar automatically
                LoadAttendanceDataByDate();
                return;
            }

            // Refresh current date data
            LoadAttendanceDataByDate();
        }

        private void LoadAttendanceDataByDate()
        {
            string query = @"
                SELECT 
                    A.AttendanceId,
                    (E.FirstName + ' ' + E.LastName) AS EmployeeName,
                    E.Position,
                    A.AttendanceDate,
                    FORMAT(A.TimeIn, 'hh:mm tt') AS TimeIn,
                    FORMAT(A.TimeOut, 'hh:mm tt') AS TimeOut
                FROM Attendance A
                INNER JOIN Employees E ON A.EmployeeId = E.EmployeeId
                WHERE CAST(A.AttendanceDate AS DATE) = @SelectedDate
                ORDER BY A.TimeIn ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SelectedDate", dateTimePicker.Value.Date);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAttendance.DataSource = dt;

                    FormatAttendanceGrid();
                }
            }
        }
        public void RefreshAttendance()
        {
            LoadAttendanceDataByDate();
        }
        private void FormatAttendanceGrid()
        {
            if (dgvAttendance.Columns.Count == 0) return;

            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAttendance.RowTemplate.Height = 40;

            foreach (DataGridViewColumn col in dgvAttendance.Columns)
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            AttendanceIn frm = new AttendanceIn(this);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAttendanceDataByDate();
            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            AttendanceOut frm = new AttendanceOut(this);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAttendanceDataByDate();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormStaff staffForm = new FormStaff();
            staffForm.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            DataGridViewRow row = dgvAttendance.SelectedRows[0];

            AttendanceEdit editForm = new AttendanceEdit(
                row.Cells["AttendanceId"].Value.ToString(),
                row.Cells["EmployeeName"].Value.ToString(),
                row.Cells["AttendanceDate"].Value.ToString(),
                row.Cells["TimeIn"].Value.ToString(),
                row.Cells["TimeOut"].Value?.ToString()
            );

            editForm.ShowDialog();
            LoadAttendanceDataByDate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            string attendanceID = dgvAttendance.SelectedRows[0].Cells["AttendanceId"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Attendance WHERE AttendanceId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", attendanceID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadAttendanceDataByDate();
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceDataByDate();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string dateStamp = DateTime.Now.ToString("MM-dd-yyyy");
            string defaultFileName = $"Attendance_Report_{dateStamp}.csv";

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File|*.csv";
            save.FileName = defaultFileName;

            if (save.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(save.FileName, false);

                // Write headers
                for (int i = 0; i < dgvAttendance.Columns.Count; i++)
                    sw.Write(dgvAttendance.Columns[i].HeaderText + ",");

                sw.WriteLine();

                // Write rows
                foreach (DataGridViewRow row in dgvAttendance.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dgvAttendance.Columns.Count; i++)
                        {
                            string value = row.Cells[i].Value?.ToString()?.Replace(",", " ") ?? "";
                            sw.Write(value + ",");
                        }

                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Export successful!");
            }
        }

        private void navbarLeft_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SalaryForm salaryForm = new SalaryForm();
            salaryForm.ShowDialog();
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
    }
}
