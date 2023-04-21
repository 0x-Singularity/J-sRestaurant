using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint_2_GUI_Group1_1
{
    internal abstract class FloorStaff : Employee
    {
        protected Table[] TablesAssigned = new Table[28];
        public FloorStaff(string Name, int Password) : base (Name, Password) { }
        public bool AssignTables(bool ManagerLoggedIn, Table[] TablesAssigned) //move method to FloorStaff
        {
            if (ManagerLoggedIn)
            {
                this.TablesAssigned = TablesAssigned;
                return true;
            }
            return false;
        }
        public Table[] GetAssignedTables()
        {
            return TablesAssigned;
        }
        public abstract void ChangeTableStatus(Table AssignedTable, byte Status);
    }
}
