using System;
using System.Collections.Generic;
using System.Security;

namespace Sprint_2_GUI_Group1_1
{
    internal class Item
    {
        private string Name;
        private float Cost;
        private static int ItemNum = 1;
        private int ItemID;
        private bool Customizable;
        private string Category;
        public Item(string Name, float Cost, bool Customizable, string Category)
        {
            this.Name = Name;
            ItemID = ItemNum++;
            this.Cost = Cost;
            this.Customizable = Customizable;
            this.Category = Category;
        }
        public bool isCustomizable()
        {
            return Customizable;
        }
        public int GetItemID()
        {
            return ItemID;
        }
        public string GetCategory()
        {
            return Category;
        }
        public float GetCost()
        {
            return Cost;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
