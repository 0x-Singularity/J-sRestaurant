using Sprint_2_GUI_Group1_1;
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
        private FloorStaff CurrentEmployee;
        private bool isLoggedIn;
        private EmployeeLoginScreen EmployeeLogin;
        private DiningRoom DiningRoom;
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
        internal void LogInCurrentEmployee(bool isLoggedIn, FloorStaff CurrentEmployee)
        {
            this.CurrentEmployee = CurrentEmployee;
            ShowCurrentEmployee.Text = "Current Employee: " + CurrentEmployee.GetEmployeeName();
            isLoggedIn = true;

        }
        internal void ScreenPointer(EmployeeLoginScreen UserControlToPointTo)
        {
            EmployeeLogin = UserControlToPointTo;
        }
        internal void ScreenPointer2(DiningRoom UserControlToPointTo)
        {
            DiningRoom = UserControlToPointTo;
        }
        internal void ScreenPointer3(UserControl UserControlToPointTo)
        {
            Screen3 = UserControlToPointTo;
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            DiningRoom.SetEmployee(CurrentEmployee);
            DiningRoom.Show();
            Hide();
        }
    }
}
