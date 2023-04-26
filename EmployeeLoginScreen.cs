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
    public partial class EmployeeLoginScreen : UserControl
    {
        /// <summary>
        /// Attributes:
        ///  CurrentManager (private pointer object of type Manager)
        ///  CurrentEmployee (private pointer object of type Employee)
        ///  isLoggedIn (private boolean)
        ///  EmployeeMenu (private pointer object of type MenuForEmployee)
        /// </summary>
        private Manager CurrentManager;
        private Employee CurrentEmployee;
        private bool isLoggedIn;
        private MenuForEmployee EmployeeMenu;

        /// <summary>
        /// EmployeeLoginScreen Constructor
        /// </summary>
        /// <param name="CurrentManager"></param>
        internal EmployeeLoginScreen()
        {
            InitializeComponent();
            Response.Hide();
            GoBackToMenu.Hide();
            HideLogoutPanel();
        }

        /// <summary>
        /// Sets the CurrentManager pointer to the passed in Manager object.
        /// </summary>
        /// <param name="ManagerToSet"></param>
        internal void SetManager(Manager ManagerToSet)
        {
            CurrentManager = ManagerToSet;
        }

        /// <summary>
        /// Paints the rectangles on the object's screen
        /// </summary>
        /// <param name="Event"></param>
        protected override void OnPaint(PaintEventArgs Event)
        {
            Graphics GraphicalUnit = Event.Graphics;
            SolidBrush MiddleColor = new SolidBrush(Color.Silver);
            Rectangle Middle = new Rectangle(340, 10, 400, 500);
            GraphicalUnit.FillRectangle(MiddleColor, Middle);
            base.OnPaint(Event);
        }

        /// <summary>
        /// Returns the boolean isLoggedIn;
        /// </summary>
        /// <returns></returns>
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }

        /// <summary>
        /// Displays the InFrontBackgroundPanel Panel object
        /// </summary>
        public void ShowLogoutPanel()
        {
            InFrontBackgroundPanel.Show();
            YesLogout.Show();
            NoLogout.Show();
            AreYouSure.Show();
        }

        /// <summary>
        /// Hides the InFrontBackgroundPanel Panel object
        /// </summary>
        public void HideLogoutPanel()
        {
            InFrontBackgroundPanel.Hide();
            YesLogout.Hide();
            NoLogout.Hide();
            AreYouSure.Hide();
        }

        /// <summary>
        /// Modifies the Text of the KeypadInput TextBox object
        /// </summary>
        /// <param name="KeypadNum"></param>
        private void ChangeKeypadInputText(int KeypadNum)
        {
            if (!(KeypadInput.TextLength >= 4))
            {
                KeypadInput.Text = KeypadInput.Text + KeypadNum;
            }
        }

        /// <summary>
        /// Keypad Digit 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad1_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(1);
        }

        /// <summary>
        /// Keypad Digit 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad2_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(2);
        }

        /// <summary>
        /// Keypad Digit 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad3_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(3);
        }

        /// <summary>
        /// Keypad Digit 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad4_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(4);
        }

        /// <summary>
        /// Keypad Digit 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad5_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(5);
        }

        /// <summary>
        /// Keypad Digit 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad6_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(6);
        }

        /// <summary>
        /// Keypad Digit 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad7_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(7);
        }

        /// <summary>
        /// Keypad Digit 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad8_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(8);
        }

        /// <summary>
        /// Keypad Digit 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad9_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(9);
        }

        /// <summary>
        /// Keypad Digit 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Keypad0_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(0);
        }

        /// <summary>
        /// Keypad Backspace Button object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeypadBackspace_Click(object sender, EventArgs e)
        {
            if (!Response.Text.Equals(""))
            {
                Response.Hide();
                Response.Text = "";
                KeypadInput.Text = null;
            }
            else if (!KeypadInput.Text.Equals(null))
            {
                if (!(KeypadInput.TextLength <= 0)) KeypadInput.Text = KeypadInput.Text.Substring(0, KeypadInput.TextLength - 1);
            }
        }

        /// <summary>
        /// Keypad Submit Button object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeypadSubmit_Click(object sender, EventArgs e)
        {
            //Try-Catch to catch any exceptions and avoid crashing
            try
            {
                if (!KeypadInput.Text.Equals(null))
                {
                    int TempPass = Convert.ToInt32(KeypadInput.Text);
                    Employee E = CurrentManager.CheckEmployeePasswords(TempPass);
                    if (isLoggedIn)
                    {
                        if (TempPass == CurrentEmployee.GetEmployeePassword())
                        {
                            ShowLogoutPanel();
                            return;
                        }
                        else
                        {
                            Response.Text = "Only one employee can log in at a time.";
                            KeypadInput.Text = "";
                        }
                    }
                    else if (E != null)
                    {
                        Response.Show();
                        Response.Text = "Hello, " + E.GetEmployeeName() + "!";
                        isLoggedIn = true;
                        CurrentEmployee = E;
                        KeypadInput.Text = null;
                        if (EmployeeMenu != null)
                        {
                            ChangeScreensWithPointer();
                            LoginCurrentEmployee(E);
                            EmployeeMenu.LogInCurrentEmployee(CurrentEmployee);
                        }
                    }
                    else
                    {
                        Response.Show();
                        Response.Text = "Invalid Password, Please Try Again.";
                        isLoggedIn = false;
                    }
                }
                else Response.Hide();
            }
            catch (Exception E)
            {
                Response.Text = "Error: " + E.Message;
            }
        }

        /// <summary>
        /// Points to specified object of type MenuForEmployee named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        public void ScreenPointer(MenuForEmployee Pointer)
        {
            this.EmployeeMenu = Pointer;
        }

        /// <summary>
        /// Changes the displayed screen with the pointer EmployeeMenu.
        /// </summary>
        internal void ChangeScreensWithPointer()
        {
            Hide();
            EmployeeMenu.Show();
        }

        /// <summary>
        /// Adds the functionality for the GUI button to logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesLogout_Click(object sender, EventArgs e)
        {
            LogoutCurrentEmployee();
            HideLogoutPanel();
            Response.Show();
            Response.Text = "Logout Successful.";
        }

        /// <summary>
        /// Adds the functionality for the GUI button to not logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoLogout_Click(object sender, EventArgs e)
        {
            HideLogoutPanel();
            Response.Text = "Employee Logged In: " + CurrentEmployee.GetEmployeeName();
            KeypadInput.Text = null;
        }

        /// <summary>
        /// Logs in the passed in Employee object.
        /// </summary>
        /// <param name="CurrentEmployee"></param>
        private void LoginCurrentEmployee(Employee CurrentEmployee)
        {
            GoBackToMenu.Show();
            this.CurrentEmployee = CurrentEmployee;
        }

        /// <summary>
        /// Logs out the current employee.
        /// </summary>
        private void LogoutCurrentEmployee()
        {
            GoBackToMenu.Hide();
            CurrentEmployee = null;
            isLoggedIn = false;
            Response.Text = null;
            Response.Hide();
            KeypadInput.Text = null;
        }

        /// <summary>
        /// Adds the functionality to the GUI button that changes screens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBackToMenu_Click(object sender, EventArgs e)
        {
            ChangeScreensWithPointer();
        }
    }
}