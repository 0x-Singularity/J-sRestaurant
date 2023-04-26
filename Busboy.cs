using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Busboy : FloorStaff
    {
        /// <summary>
        /// Busboy Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        public Busboy(string Name, int Password) : base(Name, Password) { }

        /// <summary>
        /// Changes AssignedTable status to passed in Status
        /// </summary>
        /// <param name="AssignedTable"></param>
        /// <param name="Status"></param>
        public override void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            AssignedTable.ChangeTableStatus(Status);
        }
    }
}
