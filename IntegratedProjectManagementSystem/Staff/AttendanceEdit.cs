using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class AttendanceEdit : Form
    {
        private readonly string connectionString =
            @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;
              Initial Catalog=BLFDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        private string _attendanceId;

        public AttendanceEdit(string attendanceId, string name, string day, string clockIn, string clockOut)
        {
            InitializeComponent();

            _attendanceId = attendanceId;

            txtName.Text = name;
            dtpDay.Value = DateTime.Parse(day);
            txtClockIn.Text = clockIn;
            txtClockOut.Text = clockOut;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        UPDATE Attendance
                        SET 
                            AttendanceDate = @AttendanceDate,
                            TimeIn = @TimeIn,
                            TimeOut = @TimeOut
                        WHERE AttendanceId = @AttendanceId";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@AttendanceId", _attendanceId);
                    cmd.Parameters.AddWithValue("@AttendanceDate", dtpDay.Value.Date);

                    DateTime parsedIn = DateTime.Parse(txtClockIn.Text);
                    DateTime parsedOut = DateTime.Parse(txtClockOut.Text);

                    cmd.Parameters.AddWithValue("@TimeIn", dtpDay.Value.Date.Add(parsedIn.TimeOfDay));
                    cmd.Parameters.AddWithValue("@TimeOut", dtpDay.Value.Date.Add(parsedOut.TimeOfDay));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Attendance updated successfully!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
