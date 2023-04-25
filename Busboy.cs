using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Busboy : FloorStaff
    {
        public Busboy(string Name, int Password) : base(Name, Password) { }
        public override void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            AssignedTable.ChangeTableStatus(Status);
        }
    }
}
