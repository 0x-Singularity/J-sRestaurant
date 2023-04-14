using System;
using System.Collections.Generic;

namespace Sprint_2_ISWE_Group_1_1
{
    internal class Employee
    {
        protected string Name;
        protected bool Employed = true;
        protected static int EmployeeCounter = 1;
        protected static int EmployeeID;
        protected List<Table> TablesAssigned;
        public Employee(List<Table> TablesAssigned, string Name)
        {
            this.TablesAssigned = TablesAssigned;
            this.Name = Name;
            EmployeeID = EmployeeCounter++;
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
