using IntegratedProjectManagementSystem.Dashboard;
using IntegratedProjectManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            FormCreateProduct formCreateProduct = new FormCreateProduct();
            formCreateProduct.Show();

        }

        private void btnGotoMaterials_Click(object sender, EventArgs e)
        {
            FormCreateMaterial formCreateMaterial= new FormCreateMaterial();
            formCreateMaterial.Show();
        }
    }
}
