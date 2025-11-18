using Microsoft.Data.SqlClient;
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

namespace IntegratedProjectManagementSystem.Staff
{
    public partial class FormStaff : Form
    {

        private readonly string connectionString =
    @"Data Source=DESKTOP-8DH0BIP\SQLEXPRESS;
      Initial Catalog=BLFDB;
      Integrated Security=True;
      TrustServerCertificate=True;";

        private DataTable employeeTable;

        public FormStaff()
        {
            InitializeComponent();
            LoadEmployees();

        }

        private void FormatStaffGrid()
        {
            if (dataGridEmployee.Columns.Count == 0)
                return; // No columns yet – prevents crash

            // EMPLOYEE ID COLUMN
            if (dataGridEmployee.Columns.Contains("EmployeeId"))
                dataGridEmployee.Columns["EmployeeId"].Width = 70;

            // PHOTO COLUMN
            if (dataGridEmployee.Columns.Contains("EmployeePhoto"))
            {
                DataGridViewImageColumn imgCol =
                    (DataGridViewImageColumn)dataGridEmployee.Columns["EmployeePhoto"];

                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.Width = 120;
                dataGridEmployee.RowTemplate.Height = 120;
            }

            dataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void LoadEmployees()
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT EmployeeId, EmployeePhoto, FirstName, LastName, BirthDate, 
                         DailyRate, Position, Status, ContactNumber, Email, Active 
                         FROM Employees";

                System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(query, conn);
                employeeTable = new DataTable();  // store it globally
                da.Fill(employeeTable);

                dataGridEmployee.DataSource = employeeTable;

                FormatStaffGrid();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffAddForm addForm = new StaffAddForm();

            // Show form and wait for result
            var result = addForm.ShowDialog();

            // If form saved successfully → refresh list
            if (result == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to edit.");
                return;
            }

            int employeeId = Convert.ToInt32(dataGridEmployee.SelectedRows[0].Cells["EmployeeId"].Value);

            StaffEditForm editForm = new StaffEditForm(employeeId);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees(); // refresh after editing
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeId = Convert.ToInt32(dataGridEmployee.SelectedRows[0].Cells["EmployeeId"].Value);

            // Confirm delete
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Employees WHERE EmployeeId = @ID";

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Employee deleted successfully!",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEmployees(); // refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                                "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            if (dataGridEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            DataGridViewRow row = dataGridEmployee.SelectedRows[0];

            EmployeeClass emp = new EmployeeClass();

            // SAFE GETTER
            object Get(string col)
            {
                if (!row.DataGridView.Columns.Contains(col))
                    return null;

                var value = row.Cells[col].Value;
                return value == DBNull.Value ? null : value;
            }

            emp.EmployeeId = Convert.ToInt32(Get("EmployeeId"));
            emp.FirstName = Get("FirstName")?.ToString();
            emp.LastName = Get("LastName")?.ToString();
            emp.Position = Get("Position")?.ToString();
            emp.Status = Get("Status")?.ToString();
            emp.ContactNumber = Get("ContactNumber")?.ToString();
            emp.Email = Get("Email")?.ToString();

            if (Get("BirthDate") != null)
                emp.BirthDate = Convert.ToDateTime(Get("BirthDate"));

            if (Get("DailyRate") != null)
                emp.DailyRate = Convert.ToDecimal(Get("DailyRate"));

            emp.IsActive = Get("Active") != null && Convert.ToBoolean(Get("Active"));

            // 🔥 BLOCK ACCESS IF EMPLOYEE IS INACTIVE
            if (!emp.IsActive)
            {
                MessageBox.Show("This employee is inactive and cannot use Time In / Time Out.",
                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // OPEN TIME LOG FORM
            TimeLogForm f = new TimeLogForm(emp);
            f.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (employeeTable == null) return;

            string search = txtSearch.Text.Replace("'", "''"); // prevent filter errors

            // Filter across FirstName, LastName, EmployeeId, Position
            string filter = $@"
        Convert(EmployeeId, 'System.String') LIKE '%{search}%'
        OR FirstName LIKE '%{search}%'
        OR LastName LIKE '%{search}%'
        OR Position LIKE '%{search}%'
    ";

            (dataGridEmployee.DataSource as DataTable).DefaultView.RowFilter = filter;
        }
    }
}









