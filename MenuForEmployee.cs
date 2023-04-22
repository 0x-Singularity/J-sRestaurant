using Sprint_2_GUI_Group1_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        private EmployeeLoginScreen EmployeeLogin;
        private DiningRoom DiningRoom;
        private CurrentOrderDisplay CurrentOrderDisplay;
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
            UpdateText();
            isLoggedIn = true;
        }
        internal void UpdateText()
        {
            ShowCurrentEmployee.Text = "Current Employee: " + CurrentEmployee.GetEmployeeName();
        }
        internal void ScreenPointer(EmployeeLoginScreen UserControlToPointTo)
        {
            EmployeeLogin = UserControlToPointTo;
        }
        internal void ScreenPointer2(DiningRoom UserControlToPointTo)
        {
            DiningRoom = UserControlToPointTo;
        }
        internal void ScreenPointer3(CurrentOrderDisplay UserControlToPointTo)
        {
            CurrentOrderDisplay = UserControlToPointTo;
        }
        private void DiningFloor_Click(object sender, EventArgs e)  
        {
            UpdateText();
            try
            {
                if (CurrentEmployee is FloorStaff)
                {
                    DiningRoom.SetEmployee((FloorStaff)CurrentEmployee);
                    DiningRoom.Show();
                    Hide();
                }
                else if (CurrentEmployee is Employee) {
                    ShowCurrentEmployee.Text = "You are not a member of the floor staff.";
                }
            }
            catch (Exception E)
            {
                ShowCurrentEmployee.Text = "Error: " + E.Message;
            }
        }

        private void ToCurrentOrders_Click(object sender, EventArgs e)
        {
            CurrentOrderDisplay.Show();
            CurrentOrderDisplay.DisplayOnFIFOs();
            Hide();
        }
    }
}
