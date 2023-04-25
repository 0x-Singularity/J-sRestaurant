using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Waiter : FloorStaff
    {
        public Waiter(string Name, int Password) : base(Name, Password) { }
        public override void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            AssignedTable.ChangeTableStatus(Status);
        }
        public void CreateNewOrder(Table T)
        {
            T.NewOrder();
        }
        public void ModifyCurrentOrder(Table T)
        {
            T.ModifyCurrentOrder();
        }
        public void SendOrderToKitchen(Table T)
        {
            T.SendOrderToKitchen();
        }
    }
}
