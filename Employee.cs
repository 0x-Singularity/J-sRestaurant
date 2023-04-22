using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Employee
    {
        protected string Name;
        protected int Password;
        protected bool Employed = true;
        protected static int EmployeeCounter = 1;
        protected static int EmployeeID;
        public Employee(string Name, int Password)
        {
            this.Name = Name;
            EmployeeID = EmployeeCounter++;
            this.Password = Password; //Temporary
        }

        private int NewPassword()
        {
            Random Randomizer = new Random();
            int TempPass = Randomizer.Next(0, 9999);
            //check password is not already taken by a different employee
            Password = TempPass;
            return Password;
        }
        public int GetEmployeePassword()
        {
            return Password;
        }
        public bool SetEmployeePassword(bool ManagerLoggedIn, int NewPassword)
        {
            if (ManagerLoggedIn)
            {
                Password = NewPassword;
                return true;
            }
            return false;
        }
        public string GetEmployeeName()
        {
            return Name;
        }
        public void ChangeEmploymentStatus()
        {
            Employed = !Employed;
        }
        public bool isEmployed()
        {
            return Employed;
        }
    }
}
