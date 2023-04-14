using System;
using System.Collections.Generic;

namespace Sprint_2_ISWE_Group_1_1
{
    internal class Waiter : Employee
    {
        public Waiter(List<Table> TablesAssigned, string Name) : base(TablesAssigned, Name) { }
        public void ChangeTableStatus(Table AssignedTable, byte Status)
        {
            AssignedTable.ChangeTableStatus("Needs Attention");
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
