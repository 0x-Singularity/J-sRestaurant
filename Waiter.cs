using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Waiter : FloorStaff
    {
        /// <summary>
        /// Waiter Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        public Waiter(string Name, int Password) : base(Name, Password) { }

        /// <summary>
        /// Changes the AssignedTable status with the passed in Status byte.
        /// </summary>
        /// <param name="AssignedTable"></param>
        /// <param name="Status"></param>
        public override void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            AssignedTable.ChangeTableStatus(Status);
        }

        /// <summary>
        /// Calls the NewOrder method of the passed in Table object.
        /// </summary>
        /// <param name="T"></param>
        public void CreateNewOrder(Table T)
        {
            T.NewOrder();
        }
    }
}
