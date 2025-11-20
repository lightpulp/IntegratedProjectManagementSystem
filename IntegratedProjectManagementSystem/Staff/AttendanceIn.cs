using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class AttendanceIn : Form
    {

        private AttendanceForm _parent;

        private readonly string connectionString =
    @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;
      Initial Catalog=BLFDB;
      Integrated Security=True;
      TrustServerCertificate=True;";

        public AttendanceIn(AttendanceForm parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadEmployees();
        }


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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
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

                // ⛔ 1. CHECK IF EMPLOYEE ALREADY CLOCKED IN TODAY
                string checkQuery = @"
            SELECT COUNT(*) 
            FROM Attendance
            WHERE EmployeeId = @id AND AttendanceDate = CAST(GETDATE() AS DATE)
                  AND TimeIn IS NOT NULL";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id", employeeId);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("This employee has already clocked in today.",
                            "Clock-In Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // ✔ 2. INSERT CLOCK-IN IF ALLOWED
                string insertQuery = @"
            INSERT INTO Attendance (EmployeeId, AttendanceDate, TimeIn, Position)
            SELECT EmployeeId, CAST(GETDATE() AS DATE), GETDATE(), Position
            FROM Employees
            WHERE EmployeeId = @id";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@id", employeeId);
                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Clock-In recorded successfully!");

            this.DialogResult = DialogResult.OK;
            _parent.RefreshAttendance();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
