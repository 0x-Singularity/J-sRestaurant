using System;
using System.Collections.Generic;

namespace Sprint_2_GUI_Group1_1
{
    internal class Order
    {
        /// <summary>
        /// Attributes:
        ///  OrderItems (private List of Item objects)
        ///  OrderNum (static private integer object to get consective OrderIDs)
        ///  OrderID (private integer)
        ///  Status (private string)
        ///  AttachedToTableXY (private Table object)
        /// </summary>
        private List<Item> OrderItems = new List<Item>();
        private static int OrderNum = 1;
        private int OrderID;
        private string Status;
        private Table AttachedToTableXY;

        /// <summary>
        /// Order Constructor
        /// </summary>
        public Order()
        {
            OrderID = OrderNum++;
            Status = "New";
        }

        /// <summary>
        /// Returns OrderID.
        /// </summary>
        /// <returns></returns>
        public int GetID()
        {
            return OrderID;
        }

        /// <summary>
        /// Returns Status.
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            return Status;
        }

        /// <summary>
        /// Sets the AttachedToTableXY pointer to the passed in Table object
        /// </summary>
        /// <param name="T"></param>
        public void SetTable(Table T)
        {
            AttachedToTableXY = T;
        }

        /// <summary>
        /// Adds an Item object from its passed in ItemID to the Order
        /// </summary>
        /// <param name="ItemID"></param>
        public void AddItemToOrder(int ItemID)
        {
            Menu menu = new Menu();
            OrderItems.Add(menu.FindItem(ItemID));
        }

        /// <summary>
        /// Adds an Item object from its passed in ItemName to the order
        /// </summary>
        /// <param name="ItemName"></param>
        public void AddItemToOrder(string ItemName)
        {
            Menu menu = new Menu();
            OrderItems.Add(menu.FindItem(ItemName));
        }

        /// <summary>
        /// Adds a passed in Item object to the order
        /// </summary>
        /// <param name="ItemToAdd"></param>
        public void AddItemToOrder(Item ItemToAdd)
        {
            OrderItems.Add(ItemToAdd);
        }

        /// <summary>
        /// Changes the status of the AttachedToTableXY Table object to "Needs Attention"
        /// </summary>
        public void ChangeOrderTableStatus()
        {
            AttachedToTableXY.ChangeTableStatus(3);
        }

        /// <summary>
        /// Removes and Item object from the order
        /// If not possible, throws a new Exception
        /// </summary>
        /// <param name="ItemToRemove"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Searches for an Item object in the order
        /// </summary>
        /// <param name="I"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Changes the order status based on the current status of the order
        /// </summary>
        public void ChangeOrderStatus()
        {
            if (Status == null)
            {
                Status = "New";
            }
            else if (Status == "New")
            {
                Status = "Complete";
            }
        }

        /// <summary>
        /// returns the OrderItems List of Item objects
        /// </summary>
        /// <returns></returns>
        public List<Item> GetList()
        {
            return OrderItems;
        }

        /// <summary>
        /// Returns a string containing every Item object's ItemName
        /// </summary>
        /// <returns></returns>
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
