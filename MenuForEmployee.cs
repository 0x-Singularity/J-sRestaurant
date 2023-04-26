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
        /// <summary>
        /// Attributes:
        ///  CurrentEmployee (private pointer object of type Employee)
        ///  EmployeeLogin (private pointer object of type EmployeeLoginScreen)
        ///  DiningRoom (private pointer object of type DiningRoom)
        ///  CurrentOrderDisplay (private pointer object of type CurrentOrderDisplay)
        /// </summary>
        private Employee CurrentEmployee;
        private EmployeeLoginScreen EmployeeLogin;
        private DiningRoom DiningRoom;
        private CurrentOrderDisplay CurrentOrderDisplay;

        /// <summary>
        /// MenuForEmployee Constructor
        /// </summary>
        public MenuForEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the EmployeeLoginScreen object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeLogin.Show();
        }

        /// <summary>
        /// Sets the CurrentEmployee pointer to the passed in object.
        /// Calls UpdateText method.
        /// </summary>
        /// <param name="isLoggedIn"></param>
        /// <param name="CurrentEmployee"></param>
        internal void LogInCurrentEmployee(Employee CurrentEmployee)
        {
            this.CurrentEmployee = CurrentEmployee;
            UpdateText();
        }

        /// <summary>
        /// Sets the Text of ShowCurrentEmployee Label object to "Current Employee: " and the CurrentEmployee object's Name.
        /// </summary>
        internal void UpdateText()
        {
            ShowCurrentEmployee.Text = "Current Employee: " + CurrentEmployee.GetEmployeeName();
        }

        /// <summary>
        /// Points to specified object of type EmployeeLoginScreen named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        internal void ScreenPointer(EmployeeLoginScreen Pointer)
        {
            EmployeeLogin = Pointer;
        }

        /// <summary>
        /// Points to specified object of type DiningRoom named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        internal void ScreenPointer2(DiningRoom Pointer)
        {
            DiningRoom = Pointer;
        }

        /// <summary>
        /// Points to specified object of type CurrentOrderDisplay named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        internal void ScreenPointer3(CurrentOrderDisplay Pointer)
        {
            CurrentOrderDisplay = Pointer;
        }

        /// <summary>
        /// Calls the UpdateText method.
        /// Adds the functionality to the GUI button to Change screens with the DiningRoom object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Returns the CurrentEmployee object.
        /// </summary>
        /// <returns></returns>
        internal Employee GetCurrentEmployee()
        {
            return CurrentEmployee;
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the CurrentOrderDisplay object's screen
        /// Updates the CurrentOrderDisplay object's screen with the DisplayOnFIFOs method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToCurrentOrders_Click(object sender, EventArgs e)
        {
            CurrentOrderDisplay.Show();
            CurrentOrderDisplay.DisplayOnFIFOs();
            Hide();
        }
    }
}
