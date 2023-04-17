using System;
using System.Collections.Generic;

namespace Sprint_2_Group_1_1
{
    internal class EmployeeLogin
    {
        private bool ManagerLoggedIn;
        private bool EmployeeLoggedIn;
        EmployeeLogin(bool ManagerLoggedIn)
        {
            this.ManagerLoggedIn = ManagerLoggedIn;
        }
        public void CheckLogInInformation()
        {
            //empty method to illustrate on UML
        }
        public void LogIn()
        {
            if (ManagerLoggedIn)
            {
                EmployeeLoggedIn = true;
            }
        }
        public void LogOut()
        {
            if (ManagerLoggedIn)
            {
                EmployeeLoggedIn = false;
            }
        }
    }
}
