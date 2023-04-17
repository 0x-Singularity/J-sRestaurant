using System;
using System.Collections.Generic;

namespace Sprint_2_Group_1_1
{
    internal class Host : FloorStaff
    {
        public Host(string Name, int Password) : base(Name, Password) { }
        public override void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            if (Status == 0)
            {
                AssignedTable.ChangeTableStatus("Clean");
            }
            else if (Status == 1)
            {
                AssignedTable.ChangeTableStatus("Occupied");
            }
        }
    }
}
