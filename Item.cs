using System;
using System.Collections.Generic;
using System.Security;

namespace Sprint_2_GUI_Group1_1
{
    internal class Item
    {
        /// <summary>
        /// Attributes:
        ///  Name (private string)
        ///  Cost (private float)
        ///  ItemNum (static private integer)
        ///  ItemID (private integer)
        ///  Customizable (private boolean)
        ///  Category (private string)
        /// </summary>
        private string Name;
        private float Cost;
        private static int ItemNum = 1;
        private int ItemID;
        private bool Customizable;
        private string Category;

        /// <summary>
        /// Item Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Cost"></param>
        /// <param name="Customizable"></param>
        /// <param name="Category"></param>
        public Item(string Name, float Cost, bool Customizable, string Category)
        {
            this.Name = Name;
            ItemID = ItemNum++;
            this.Cost = Cost;
            this.Customizable = Customizable;
            this.Category = Category;
        }

        /// <summary>
        /// Returns the Customizable boolean.
        /// </summary>
        /// <returns></returns>
        public bool isCustomizable()
        {
            return Customizable;
        }

        /// <summary>
        /// Returns the ItemID integer.
        /// </summary>
        /// <returns></returns>
        public int GetItemID()
        {
            return ItemID;
        }

        /// <summary>
        /// Returns the Category string.
        /// </summary>
        /// <returns></returns>
        public string GetCategory()
        {
            return Category;
        }

        /// <summary>
        /// Returns the Cost float.
        /// </summary>
        /// <returns></returns>
        public float GetCost()
        {
            return Cost;
        }

        /// <summary>
        /// Returns the Name string.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }
    }
}
