using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Manager
    {
        private string Username;
        private string Password;
        private List<Employee> Employees;
        public Manager(List<Employee> Employees, string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            this.Employees = Employees;
        }

        public Employee CheckEmployeePasswords(int PasswordToCheck)
        {
            foreach (Employee E in Employees)
            {
                int TempPass = E.GetEmployeePassword();
                if (PasswordToCheck == TempPass)
                {
                    return E as Employee;
                }
            }
            return null;
        }
        public void AddNewEmployee(Employee EmployeeToAdd)
        {
            Employees.Add(EmployeeToAdd);
        }
        public void RemoveEmployee(Employee EmployeeToRemove)
        {
            Employees.Remove(EmployeeToRemove);
        }
        public void ChangeEmployeeRole(Employee EmployeeToChangeRole)
        {

        }
        public void ModifyCurrentMenu()
        {

        }
        public void AssignTables(Employee EmployeeToAssignTo)
        {

        }
    }
}
