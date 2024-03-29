﻿using System;
using System.Collections.Generic;
using static System.Windows.Forms.Design.AxImporter;
using System.Drawing;
using System.Security.Cryptography;

namespace Sprint_2_GUI_Group1_1
{
    internal class Menu
    {
        /// <summary>
        /// Attributes:
        ///  MenuItems (protected List of Item objects)
        /// </summary>
        protected List<Item> MenuItems = new List<Item>();

        /// <summary>
        /// Menu Constructor
        /// </summary>
        internal Menu()
        {
            FillMenu();
        }

        /// <summary>
        /// Fills the MenuItems List of Item objects with Item objects.
        /// </summary>
        public void FillMenu()
        {
            //Entree, total: 4
            MenuItems.Add(new Item("Shrimp & Grits", 13.50f, false, "Entree"));         //1
            MenuItems.Add(new Item("Sweet Tea Fried Chicken", 11.50f, false, "Entree"));//2
            MenuItems.Add(new Item("Caribbean Chicken", 11.50f, false, "Entree"));      //3
            MenuItems.Add(new Item("Grilled Pork Chops", 11.00f, false, "Entree"));     //4

            //Sides, total: 4
            MenuItems.Add(new Item("Curly Fries", 2.50f, false, "Side"));               //5
            MenuItems.Add(new Item("Wing Chips", 2.50f, false, "Side"));                //6
            MenuItems.Add(new Item("Creamy Cabbage Slaw", 2.50f, false, "Side"));       //7
            MenuItems.Add(new Item("Mashed Potatoes", 2.50f, false, "Side"));           //8

            //Sandwich, total: 4
            MenuItems.Add(new Item("Chicken BLT&A", 10.00f, false, "Sandwich"));        //9
            MenuItems.Add(new Item("Cordon Bleu", 11.00f, false, "Sandwich"));          //10
            MenuItems.Add(new Item("Club", 10.00f, false, "Sandwich"));                 //11
            MenuItems.Add(new Item("Po Boy", 11.50f, false, "Sandwich"));               //12

            //Wrap, total: 4
            MenuItems.Add(new Item("Club", 10.00f, false, "Wrap"));                     //13
            MenuItems.Add(new Item("Chicken BLT&A", 10.00f, false, "Wrap"));            //14
            MenuItems.Add(new Item("Veggie", 10.00f, false, "Wrap"));                   //15
            MenuItems.Add(new Item("Chicken Caesar", 10.00f, false, "Wrap"));           //16

            //Beverage, total: 4
            MenuItems.Add(new Item("Coffee", 2.00f, false, "Beverage"));                //17
            MenuItems.Add(new Item("Sweet Tea", 2.00f, false, "Beverage"));             //18
            MenuItems.Add(new Item("Coke", 2.00f, false, "Beverage"));                  //19
            MenuItems.Add(new Item("Bottled Water", 2.00f, false, "Beverage"));         //20

        }

        /// <summary>
        /// Returns an Item object array of a specified Category string.
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        public Item[] GetArrayOfCategory(string Category)
        {
            List<Item> ListOfItems = new List<Item>();
            foreach (Item I in MenuItems)
            {
                if (I.GetCategory() == Category)
                {
                    ListOfItems.Add(I);
                }
            }
            return ListOfItems.ToArray<Item>();
        }

        /// <summary>
        /// Returns the Item at the passed in ItemID integer.
        /// </summary>
        /// <param name="ItemID"></param>
        /// <returns></returns>
        public Item FindItem(int ItemID)
        {
            return MenuItems[ItemID];
        }

        /// <summary>
        /// Returns the Item containing the passed in ItemName string.
        /// </summary>
        /// <param name="ItemName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Item FindItem(string ItemName)
        {
            foreach (Item I in MenuItems)
            {
                if (I.GetName() == ItemName)
                {
                    return I;
                }
            }
            throw new Exception("Specified item to look for is not in current menu.");
        }
    }
}