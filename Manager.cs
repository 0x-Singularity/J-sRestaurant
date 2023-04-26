using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Manager
    {
        /// <summary>
        /// Attributes: 
        ///  DiningRoomPointer (private pointer object of type DiningRoom)
        ///  Username (private string)
        ///  Password (private string)
        ///  Employees (private List containing Employee objects)
        /// </summary>
        private DiningRoom DiningRoomPointer;
        private string Username;
        private string Password;
        private List<Employee> Employees;

        /// <summary>
        /// Manager Constructor
        /// </summary>
        /// <param name="Employees"></param>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        public Manager(List<Employee> Employees, string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            this.Employees = Employees;
        }

        /// <summary>
        /// Checks passed in integer against current Employee object passwords
        /// </summary>
        /// <param name="PasswordToCheck"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds the passed in Employee object to the Employees List
        /// </summary>
        /// <param name="EmployeeToAdd"></param>
        public void AddNewEmployee(Employee EmployeeToAdd)
        {
            Employees.Add(EmployeeToAdd);
        }

        /// <summary>
        /// Removes the passed in Employee object from the Employees List
        /// </summary>
        /// <param name="EmployeeToRemove"></param>
        public void RemoveEmployee(Employee EmployeeToRemove)
        {
            Employees.Remove(EmployeeToRemove);
        }
    }
}
