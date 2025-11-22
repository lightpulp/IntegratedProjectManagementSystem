using IntegratedProjectManagementSystem.Dashboard;
using IntegratedProjectManagementSystem.Projects;
using IntegratedProjectManagementSystem.Resources;
using IntegratedProjectManagementSystem.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace IntegratedProjectManagementSystem.Inventory
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void btnGotoProducts_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.Show();
            Hide();
        }

        private void btnGotoMaterials_Click(object sender, EventArgs e)
        {
            FormCreateMaterial formCreateMaterial = new FormCreateMaterial();
            formCreateMaterial.Show();
        }

        /// NAVIGATION ///
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            
        }
        private void btnProjects_Click(object sender, EventArgs e)
        {
            

        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormDashboard>(this);
        }

        private void btnProjects_Click_1(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormProject>(this);
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormInventory>(this);
        }

        private void btnStaff_Click_1(object sender, EventArgs e)
        {
            HelperNavigation.OpenForm<FormStaff>(this);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            HelperNavigation.ReturnToLogin(this);
        }
    }
}
