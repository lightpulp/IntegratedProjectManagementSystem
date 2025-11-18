using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegratedProjectManagementSystem.Resources;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class StaffAddForm : Form
    {
        public StaffAddForm()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            cbPosition.Items.AddRange(new[]
            {
                "Manager", "Assistant", "Staff", "Cashier", "Supervisor", "Clerk"
            });

            cbStatus.Items.AddRange(new[]
            {
                "Active", "On Leave", "Resigned"
            });

            cbStatus.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
        }

        private byte[] ImageToBytes(PictureBox pb)
        {
            if (pb.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                INSERT INTO Employees
                (FirstName, LastName, BirthDate, DailyRate, Position, Status,
                 ContactNumber, Email, Active, EmployeePhoto)
                VALUES
                (@FirstName, @LastName, @BirthDate, @DailyRate, @Position, @Status,
                 @ContactNumber, @Email, @Active, @EmployeePhoto)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);
                        cmd.Parameters.AddWithValue("@DailyRate", numDailyRate.Value);
                        cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", maskedContact.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Active", chkActive.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@EmployeePhoto",
                            (object)ImageToBytes(picEmployee) ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee added successfully!",
                                "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;  // 🔥 IMPORTANT
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                                "Insert Failed", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please complete all required fields.",
                                "Validation", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.",
                                "Validation", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picEmployee.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
