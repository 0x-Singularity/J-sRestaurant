using System;
using System.Collections.Generic;

namespace Sprint_2_ISWE_Group_1_1
{
    internal class Order
    {
        private List<Item> OrderItems = new List<Item>();
        private static int OrderNum = 1;
        private int OrderID;
        private string Status;
        private bool New = false;
        private bool InProgress = false;
        private bool Complete = false;
        public Order()
        {
            OrderID = OrderNum++;
            Status = "New";
        }
        public int GetID()
        {
            return OrderID;
        }
        public void AddItemToOrder(int ItemID)
        {
            Menu menu = new Menu();
            OrderItems.Add(menu.FindItem(ItemID));
        }
        public void ChangeOrderStatus()
        {
            if (New)
            {
                InProgress = true;
                New = false;
            }
            else if (InProgress)
            {
                Complete = true;
                InProgress = false;
            }
        }
    }
}
