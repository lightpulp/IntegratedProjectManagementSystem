using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class AttendanceOut : Form
    {
        private AttendanceForm _parent;


        private readonly string connectionString =
            @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;
              Initial Catalog=BLFDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public AttendanceOut(AttendanceForm parent)
        {
            InitializeComponent();
            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            LoadEmployees();
        }

        public event Action ClockOutCompleted;

        private void LoadEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT EmployeeId, FirstName + ' ' + LastName AS FullName FROM Employees WHERE Active = 1";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbEmployee.DataSource = dt;
                cmbEmployee.DisplayMember = "FullName";
                cmbEmployee.ValueMember = "EmployeeId";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbEmployee.SelectedValue == null)
                {
                    MessageBox.Show("Please select an employee.");
                    return;
                }

                int employeeId = (int)cmbEmployee.SelectedValue;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1️⃣ FIND ATTENDANCE ROW FOR TODAY (TimeIn must exist)
                    string checkQuery = @"
                    SELECT AttendanceId
                    FROM Attendance
                    WHERE EmployeeId = @id 
                      AND AttendanceDate = CAST(GETDATE() AS DATE)
                      AND TimeIn IS NOT NULL
                ";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", employeeId);

                    object result = checkCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("This employee has NOT clocked in yet today.",
                                        "Clock-Out Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int attId = Convert.ToInt32(result);

                    // 2️⃣ UPDATE ONLY TimeOut (same row)
                    string updateQuery = @"
                    UPDATE Attendance
                    SET TimeOut = GETDATE()
                    WHERE AttendanceId = @attId
                ";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@attId", attId);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Clock-Out recorded!");

                    // when done:
                    ClockOutCompleted?.Invoke();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during clock-out: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}