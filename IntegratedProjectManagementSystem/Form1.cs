using IntegratedProjectManagementSystem.Resources;

namespace IntegratedProjectManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.ValidateUser(txtUsername.Text, txtPassword.Text))
            {
                string role = DatabaseHelper.GetUserRole(txtUsername.Text);
                MessageBox.Show($"Login successful! Role: {role}");
                var dashboard = new Dashboard.FormDashboard();
                dashboard.Show();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }
    }
}
