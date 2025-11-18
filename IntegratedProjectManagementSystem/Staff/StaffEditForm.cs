using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IntegratedProjectManagementSystem.Resources;

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class StaffEditForm : Form
    {
        private int employeeId;

        public StaffEditForm(int id)
        {
            InitializeComponent();
            employeeId = id;

            LoadComboBoxes();
            LoadEmployeeData();
        }

        // -----------------------------------------------------------
        // LOAD COMBOBOX VALUES
        // -----------------------------------------------------------
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
        }

        // -----------------------------------------------------------
        // LOAD EXISTING EMPLOYEE
        // -----------------------------------------------------------
        private void LoadEmployeeData()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Employees WHERE EmployeeId = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", employeeId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtFirstName.Text = dr["FirstName"].ToString();
                            txtLastName.Text = dr["LastName"].ToString();
                            dtBirthDate.Value = Convert.ToDateTime(dr["BirthDate"]);
                            numDailyRate.Value = Convert.ToDecimal(dr["DailyRate"]);
                            cbPosition.Text = dr["Position"].ToString();
                            cbStatus.Text = dr["Status"].ToString();
                            maskedContact.Text = dr["ContactNumber"].ToString();
                            txtEmail.Text = dr["Email"].ToString();
                            chkActive.Checked = Convert.ToBoolean(dr["Active"]);

                            if (dr["EmployeePhoto"] != DBNull.Value)
                            {
                                byte[] imgData = (byte[])dr["EmployeePhoto"];
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    picEmployee.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
        }

        // -----------------------------------------------------------
        // IMAGE TO BYTE[]
        // -----------------------------------------------------------
        private byte[] ImageToBytes(PictureBox pb)
        {
            if (pb.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bmp = new Bitmap(pb.Image)) // Clones image → prevents GDI errors
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                return ms.ToArray();
            }
        }

        // -----------------------------------------------------------
        // SAVE UPDATE
        // -----------------------------------------------------------
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
                        UPDATE Employees SET
                            FirstName = @FirstName,
                            LastName = @LastName,
                            BirthDate = @BirthDate,
                            DailyRate = @DailyRate,
                            Position = @Position,
                            Status = @Status,
                            ContactNumber = @ContactNumber,
                            Email = @Email,
                            Active = @Active,
                            EmployeePhoto = @EmployeePhoto
                        WHERE EmployeeId = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", employeeId);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);
                        cmd.Parameters.AddWithValue("@DailyRate", numDailyRate.Value);
                        cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", maskedContact.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Active", chkActive.Checked ? 1 : 0);

                        // Fixed image saving
                        byte[] imageBytes = ImageToBytes(picEmployee);
                        if (imageBytes != null)
                            cmd.Parameters.Add("@EmployeePhoto", SqlDbType.VarBinary).Value = imageBytes;
                        else
                            cmd.Parameters.Add("@EmployeePhoto", SqlDbType.VarBinary).Value = DBNull.Value;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee updated successfully!",
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------------------------------------------
        // CANCEL
        // -----------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // -----------------------------------------------------------
        // BROWSE IMAGE
        // -----------------------------------------------------------
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

        // -----------------------------------------------------------
        // VALIDATION
        // -----------------------------------------------------------
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill up all required fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email format.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
