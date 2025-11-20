using IntegratedProjectManagementSystem.Resources;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IntegratedProjectManagementSystem.Projects
{
    public partial class FormClickProject_AddEmployee : Form
    {
        private int _projectId;

        public FormClickProject_AddEmployee(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
            LoadAvailableEmployees();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvEmployeeList.AutoGenerateColumns = false;
            dgvEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEmployeeList.Columns.Clear();
            dgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "EmployeeId",
                DataPropertyName = "EmployeeId",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });
            dgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FullName",
                DataPropertyName = "FullName",
                HeaderText = "Employee Name",
                Width = 150
            });
            dgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Position",
                DataPropertyName = "Position",
                HeaderText = "Position",
                Width = 100
            });
            dgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "DailyRate",
                DataPropertyName = "DailyRate",
                HeaderText = "Daily Rate",
                Width = 80
            });
            dgvEmployeeList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 80
            });
        }

        private void LoadAvailableEmployees()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            EmployeeId,
                            FirstName + ' ' + LastName as FullName,
                            Position,
                            DailyRate,
                            Status
                        FROM Employees 
                        WHERE Active = 1 
                        AND EmployeeId NOT IN (
                            SELECT EmployeeId FROM ProjectEmployees WHERE ProjectId = @ProjectId
                        )
                        ORDER BY FirstName, LastName";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@ProjectId", _projectId);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvEmployeeList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int employeeId = Convert.ToInt32(dgvEmployeeList.SelectedRows[0].Cells["EmployeeId"].Value);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO ProjectEmployees (ProjectId, EmployeeId)
                        VALUES (@ProjectId, @EmployeeId)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProjectId", _projectId);
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee to project: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}