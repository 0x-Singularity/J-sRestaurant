using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Host : FloorStaff
    {
        /// <summary>
        /// Host Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        public Host(string Name, int Password) : base(Name, Password) { }

        /// <summary>
        /// Changes AssignedTable status to the passed in Status
        /// </summary>
        /// <param name="AssignedTable"></param>
        /// <param name="Status"></param>
        public override void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            AssignedTable.ChangeTableStatus(Status);
        }
    }
}
