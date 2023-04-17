using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_2_Group_1_1
{
    internal abstract class FloorStaff : Employee
    {
        protected List<Table> TablesAssigned = new List<Table>();
        public FloorStaff(string Name, int Password) : base (Name, Password) { }
        public bool AssignTables(bool ManagerLoggedIn, List<Table> TablesAssigned) //move method to FloorStaff
        {
            if (ManagerLoggedIn)
            {
                this.TablesAssigned = TablesAssigned;
                return true;
            }
            return false;
        }
        public abstract void ChangeTableStatus(Table AssignedTable, byte Status);
    }
}
