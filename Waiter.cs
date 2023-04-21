using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Waiter : FloorStaff
    {
        public Waiter(string Name, int Password) : base(Name, Password) { }
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
            else
            {
                AssignedTable.ChangeTableStatus("Needs Attention");
            }
        }
        public void CreateNewOrder(Table T)
        {
            
        }
        public void ChangeCurrentOrder(Table T)
        {
            T.ChangeCurrentOrder();
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
