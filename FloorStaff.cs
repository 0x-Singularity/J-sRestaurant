using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_2_GUI_Group1_1
{
    internal abstract class FloorStaff : Employee
    {
        /// <summary>
        /// Attributes:
        ///  TablesAssigned (protected string array)
        /// </summary>
        protected string[] TablesAssigned = new string[28];

        /// <summary>
        /// FloorStaff Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        public FloorStaff(string Name, int Password) : base (Name, Password) { }

        /// <summary>
        /// Assigns the tables with their TableIDs.
        /// </summary>
        /// <param name="ManagerLoggedIn"></param>
        /// <param name="TablesAssigned"></param>
        /// <returns></returns>
        public bool AssignTables(bool ManagerLoggedIn, string[] TablesAssigned)
        {
            if (ManagerLoggedIn)
            {
                this.TablesAssigned = TablesAssigned;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns the string array of assigned TableIDs.
        /// </summary>
        /// <returns></returns>
        public string[] GetAssignedTables()
        {
            return TablesAssigned;
        }
        
        /// <summary>
        /// Abstract method to Change the AssignedTable status.
        /// </summary>
        /// <param name="AssignedTable"></param>
        /// <param name="Status"></param>
        public abstract void ChangeTableStatus(Table AssignedTable, byte Status);
    }
}
