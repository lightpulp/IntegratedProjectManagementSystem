using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IntegratedProjectManagementSystem.Staff
{
    public partial class TimeLogForm : Form
    {
        private EmployeeClass _employee;
        private System.Windows.Forms.Timer _timerUi; // UI update timer

        public TimeLogForm(EmployeeClass emp)
        {
            InitializeComponent();
            _employee = emp;


            this.Load += TimeLogForm_Load;

            lblName.Text = emp.GetFullName();
            lblRate.Text = $"₱{emp.DailyRate}";

            // Create the UI timer
            _timerUi = new System.Windows.Forms.Timer();
            _timerUi.Interval = 1000; // 1 second
            _timerUi.Tick += TimerUi_Tick;

            this.Load += TimeLogForm_Load;
        }

        private void TimeLogForm_Load(object sender, EventArgs e)
        {
            // Check if this employee has an active timer
            if (TimerManager.HasActiveTimer(_employee.EmployeeId))
            {
                // Resume UI timer
                _timerUi.Start();

                // Display current elapsed time safely
                TimeSpan elapsed = TimerManager.GetElapsed(_employee.EmployeeId);
                lblTimer.Text = elapsed.ToString(@"hh\:mm\:ss");

                btnStart.Enabled = false;
                btnStop.Enabled = true;
                chkTimeOut.Enabled = true;
            }
            else
            {
                // No active timer = reset display
                lblTimer.Text = "00:00:00";

                btnStart.Enabled = true;
                btnStop.Enabled = false;
                chkTimeOut.Enabled = false;
            }
        }

        // START button
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!_employee.IsActiveStatus())
            {
                MessageBox.Show("This employee is inactive.");
                return;
            }

            // 🔥 Reset salary and hours worked for new session
            lblTimer.Text = "00:00:00";
            lblHoursWorked.Text = "0.00";
            lblSalary.Text = "₱0.00";
            chkTimeOut.Checked = false;

            // 🔥 VERY IMPORTANT: always restart the global timer
            TimerManager.StartTimer(_employee.EmployeeId);

            _timerUi.Start();

            btnStart.Enabled = false;
            chkTimeOut.Enabled = true;
            btnStop.Enabled = true;
        }

        // UI Timer tick — shows live elapsed time
        private void TimerUi_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = TimerManager.GetElapsed(_employee.EmployeeId);
            lblTimer.Text = elapsed.ToString(@"hh\:mm\:ss");
        }

        // STOP button
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!chkTimeOut.Checked)
            {
                MessageBox.Show("Please check Time-Out first.");
                return;
            }

            // Get total worked hours
            TimeSpan worked = TimerManager.GetElapsed(_employee.EmployeeId);

            double hours = worked.TotalHours;
            lblHoursWorked.Text = $"{hours:0.00}";

            // Salary calculation
            decimal hourlyRate = _employee.DailyRate / 8;
            decimal salary = hourlyRate * (decimal)hours;

            lblSalary.Text = $"₱ {salary:0.00}";

            // Stop & clear global timer
            TimerManager.StopTimer(_employee.EmployeeId);

            // Stop UI updates
            _timerUi.Stop();



            btnStart.Enabled = true;
            btnStop.Enabled = false;
            chkTimeOut.Enabled = false;
        }
    }
}
