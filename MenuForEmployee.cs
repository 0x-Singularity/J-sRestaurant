using Sprint_2_Group_1_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_2_GUI_Group1_1
{
    public partial class MenuForEmployee : UserControl
    {
        private Employee CurrentEmployee;
        private bool isLoggedIn;
        private UserControl EmployeeLogin;
        private UserControl KitchenOrderDisplay;
        private UserControl Screen3;
        public MenuForEmployee()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeLogin.Show();
        }
        internal void LogInCurrentEmployee(bool isLoggedIn, Employee CurrentEmployee)
        {
            this.CurrentEmployee = CurrentEmployee;
            ShowCurrentEmployee.Text = "Current Employee: " + CurrentEmployee.GetEmployeeName();

        }
        internal void ScreenPointer(UserControl UserControlToPointTo)
        {
            EmployeeLogin = UserControlToPointTo;
        }
        internal void ScreenPointer2(UserControl UserControlToPointTo)
        {
            KitchenOrderDisplay = UserControlToPointTo;
        }
        internal void ScreenPointer3(UserControl UserControlToPointTo)
        {
            Screen3 = UserControlToPointTo;
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Hide();
            KitchenOrderDisplay.Show();
        }
    }
}
