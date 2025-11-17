using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedProjectManagementSystem.Resources
{
    public class HelperNavigation
    {
        public static void OpenForm<T>(Form currentForm) where T : Form, new()
        {
            var newForm = new T();
            newForm.Show();
            currentForm.Hide();
        }

        public static void ReturnToLogin(Form currentForm)
        {
            var loginForm = new Form1();
            loginForm.Show();
            currentForm.Close();
        }
    }
}
