using System;
using System.Collections.Generic;

namespace Sprint_2_Group_1_1
{
    internal class Menu
    {
        //Menu needs to be able to change in case manager needs to add something
        protected List<Item> MenuItems = new List<Item>();
        public void FillMenu()
        {
            MenuItems.Add(new Item("Sweet Tea", 2.00f, false, "Beverage"));
            //add the rest later if using this code
        }
        public Item FindItem(int ItemID)
        {
            return MenuItems[ItemID];
        }
        public void AddItem(Item ItemToAdd)
        {

        }
        public void RemoveItem(Item ItemToRemove)
        {

        }
    }
}