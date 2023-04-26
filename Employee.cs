using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Employee
    {
        /// <summary>
        /// Attributes:
        ///  Name (protected string)
        ///  Password (protected integer)
        ///  Employe (protected boolean)
        ///  EmployeeCounter (static protected integer to get consecutive EmployeeIDs)
        ///  EmployeeID (protected integer)
        /// </summary>
        protected string Name;
        protected int Password;
        protected bool Employed = true;
        protected static int EmployeeCounter = 1;
        protected int EmployeeID;

        /// <summary>
        /// Employee Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        public Employee(string Name, int Password)
        {
            this.Name = Name;
            EmployeeID = EmployeeCounter++;
            this.Password = Password; //Temporary
        }

        /// <summary>
        /// Creates and returns a new randomized password.
        /// </summary>
        /// <returns></returns>
        private int NewPassword()
        {
            Random Randomizer = new Random();
            int TempPass = Randomizer.Next(0, 9999);
            //check password is not already taken by a different employee
            Password = TempPass;
            return Password;
        }

        /// <summary>
        /// Returns the Password integer.
        /// </summary>
        /// <returns></returns>
        public int GetEmployeePassword()
        {
            return Password;
        }

        /// <summary>
        /// Returns true if Password is changed to the passed in NewPassword.
        /// </summary>
        /// <param name="ManagerLoggedIn"></param>
        /// <param name="NewPassword"></param>
        /// <returns></returns>
        public bool SetEmployeePassword(bool ManagerLoggedIn, int NewPassword)
        {
            if (ManagerLoggedIn)
            {
                Password = NewPassword;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns the Name string.
        /// </summary>
        /// <returns></returns>
        public string GetEmployeeName()
        {
            return Name;
        }

        /// <summary>
        /// Changes Employed to be the opposite.
        /// </summary>
        public void ChangeEmploymentStatus()
        {
            Employed = !Employed;
        }

        /// <summary>
        /// Returns Employed boolean.
        /// </summary>
        /// <returns></returns>
        public bool isEmployed()
        {
            return Employed;
        }

        public string ToString()
        {
            return Name + " " + Password;
        }
    }
}
