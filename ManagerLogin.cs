using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class ManagerLogin
    {
        /// <summary>
        /// Attributes:
        ///  ManagerLoggedin (private boolean)
        /// </summary>
        private bool ManagerLoggedIn = false;

        /// <summary>
        /// Changes ManagerLoggedIn to true;
        /// </summary>
        public void LogIn()
        {
            ManagerLoggedIn = true;
        }

        /// <summary>
        /// Changes ManagerLoggedIn to false;
        /// </summary>
        public void LogOut()
        {
            ManagerLoggedIn = false;
        }
    }
}
