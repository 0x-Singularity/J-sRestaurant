using System;
using System.Collections.Generic;

namespace Sprint_2_ISWE_Group_1_1
{
    internal class Manager
    {
        private string Username;
        private string Password;
        List<Employee> Employees = new List<Employee>();
        public Manager(List<Employee> Employees, string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            this.Employees = Employees;
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
