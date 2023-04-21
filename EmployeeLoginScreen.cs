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
        private Manager CurrentManager;
        private Employee CurrentEmployee;
        private bool isLoggedIn;
        private MenuForEmployee EmployeeMenu;
        internal EmployeeLoginScreen(Manager CurrentManager)
        {
            InitializeComponent();
            this.CurrentManager = CurrentManager;
            Response.Hide();
            GoBackToMenu.Hide();
            HideLogoutPanel();
        }

        //Paints the rectangles on the screen
        protected override void OnPaint(PaintEventArgs Event)
        {
            Graphics GraphicalUnit = Event.Graphics;
            SolidBrush MiddleColor = new SolidBrush(Color.Silver);
            Rectangle Middle = new Rectangle(340, 10, 400, 500);
            GraphicalUnit.FillRectangle(MiddleColor, Middle);
            base.OnPaint(Event);
        }
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
        public void ShowLogoutPanel()
        {
            InFrontBackgroundPanel.Show();
            YesLogout.Show();
            NoLogout.Show();
            AreYouSure.Show();
        }
        public void HideLogoutPanel()
        {
            InFrontBackgroundPanel.Hide();
            YesLogout.Hide();
            NoLogout.Hide();
            AreYouSure.Hide();
        }
        private void ChangeKeypadInputText(int KeypadNum)
        {
            if (!(KeypadInput.TextLength >= 4))
            {
                KeypadInput.Text = KeypadInput.Text + KeypadNum;
            }
        }
        private void Keypad1_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(1);
        }

        private void Keypad2_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(2);
        }

        private void Keypad3_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(3);
        }

        private void Keypad4_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(4);
        }

        private void Keypad5_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(5);
        }

        private void Keypad6_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(6);
        }

        private void Keypad7_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(7);
        }

        private void Keypad8_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(8);
        }

        private void Keypad9_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(9);
        }

        private void Keypad0_Click(object sender, EventArgs e)
        {
            ChangeKeypadInputText(0);
        }

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
                            EmployeeMenu.LogInCurrentEmployee(isLoggedIn, CurrentEmployee);
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

        public void ScreenPointer(MenuForEmployee Pointer)
        {
            this.EmployeeMenu = Pointer;
        }

        internal void ChangeScreensWithPointer()
        {
            Hide();
            EmployeeMenu.Show();
        }

        private void YesLogout_Click(object sender, EventArgs e)
        {
            LogoutCurrentEmployee();
            HideLogoutPanel();
            Response.Show();
            Response.Text = "Logout Successful.";
        }

        private void NoLogout_Click(object sender, EventArgs e)
        {
            HideLogoutPanel();
            Response.Text = "Employee Logged In: " + CurrentEmployee.GetEmployeeName();
            KeypadInput.Text = null;
        }

        private void LoginCurrentEmployee(Employee CurrentEmployee)
        {
            GoBackToMenu.Show();
            this.CurrentEmployee = CurrentEmployee;
        }

        private void LogoutCurrentEmployee()
        {
            GoBackToMenu.Hide();
            CurrentEmployee = null;
            isLoggedIn = false;
            Response.Text = null;
            Response.Hide();
            KeypadInput.Text = null;
        }

        private void GoBackToMenu_Click(object sender, EventArgs e)
        {
            ChangeScreensWithPointer();
        }
    }
}
