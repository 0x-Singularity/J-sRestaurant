using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
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
        public bool GetStatus()
        {
            if (New || InProgress)
            {
                return true;
            }
            else if (Complete)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public void AddItemToOrder(int ItemID)
        {
            Menu menu = new Menu();
            OrderItems.Add(menu.FindItem(ItemID));
        }
        public void AddItemToOrder(string ItemName)
        {
            Menu menu = new Menu();
            OrderItems.Add(menu.FindItem(ItemName));
        }
        public void AddItemToOrder(Item ItemToAdd)
        {
            OrderItems.Add(ItemToAdd);
        }
        public void RemoveItemFromOrder(Item ItemToRemove)
        {
            if (FindItemInOrder(ItemToRemove) != null)
            {
                OrderItems.Remove(ItemToRemove);
            }
            else
            {
                throw new Exception("Item not contained in order.");
            }
        }

        public Item FindItemInOrder(Item I)
        {
            foreach (Item i in OrderItems)
            {
                if (i == I)
                {
                    return i;
                }
            }
            return null;
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
        public List<Item> GetList()
        {
            return OrderItems;
        }
        public override string ToString()
        {
            string Holder = "";
            for (int i = 0; i < OrderItems.Count; i++)
            {
                Holder += "\n" + OrderItems[i].GetName();
            }
            return Holder;
        }
    }
}
