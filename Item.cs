using System;
using System.Collections.Generic;

namespace Sprint_2_ISWE_Group_1_1
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
        public void Customize()
        {
            if (Customizable)
            {
                //show customization menu
            }
            else
            {
                throw new Exception("Cannot customize this item");
            }
        }
    }
}
