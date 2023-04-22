using System;
using System.Collections.Generic;
using static System.Windows.Forms.Design.AxImporter;
using System.Drawing;
using System.Security.Cryptography;

namespace Sprint_2_GUI_Group1_1
{
    internal class Menu
    {
        //Menu needs to be able to change in case manager needs to add something
        protected List<Item> MenuItems = new List<Item>();
        public void FillMenu()
        {
            //Appetizer, total: 14
            MenuItems.Add(new Item("Chips & Dip (Pick 2)", 8.00f, true, "Appetizer"));
            MenuItems.Add(new Item("Buffalo Blue Chips", 6.00f, true, "Appetizer"));
            MenuItems.Add(new Item("Chicken Nachos", 8.50f, true, "Appetizer"));
            MenuItems.Add(new Item("Pork Nachos", 8.50f, true, "Appetizer"));
            MenuItems.Add(new Item("Pork Sliders", 5.00f, true, "Appetizer"));
            MenuItems.Add(new Item("Chicken Sliders", 5.00f, true, "Appetizer"));
            MenuItems.Add(new Item("Catfish Bites", 6.50f, false, "Appetizer"));
            MenuItems.Add(new Item("Fried Veggies", 6.50f, true, "Appetizer"));
            MenuItems.Add(new Item("Fried Cheese", 7.50f, true, "Appetizer"));
            MenuItems.Add(new Item("Cheesestick Trio", 14.00f, false, "Appetizer"));
            MenuItems.Add(new Item("Chicken Quesadilla", 7.50f, false, "Appetizer"));
            MenuItems.Add(new Item("Cast Iron Skillet Meatballs", 12.00f, true, "Appetizer"));
            MenuItems.Add(new Item("Wings (6)", 8.25f, true, "Appetizer"));
            MenuItems.Add(new Item("Wings (12)", 15.00f, true, "Appetizer"));

            //Salad, total: 6
            MenuItems.Add(new Item("House Salad (Side)", 5.00f, true, "Salad"));
            MenuItems.Add(new Item("House Salad (Main)", 7.50f, true, "Salad"));
            MenuItems.Add(new Item("Wedge Salad", 7.50f, true, "Salad"));
            MenuItems.Add(new Item("Caesar Salad (Side)", 5.00f, true, "Salad"));
            MenuItems.Add(new Item("Caesar Salad (Main)", 7.50f, true, "Salad"));
            MenuItems.Add(new Item("Sweet Potato Chicken Salad", 11.50f, true, "Salad"));
            //MenuItems.Add(new Item("Avocado (Add-on)", 1.00f, false, "Salad"));
            //MenuItems.Add(new Item("Roasted or Captain Crunch Chicken (Add-on)", 3.00f, false, "Salad"));
            //MenuItems.Add(new Item("Portobello Mushroom Cap (Add-on)", 4.00f, false, "Salad"));
            //MenuItems.Add(new Item("Grilled or Fried Shrimp (Add-on)", 6.00f, false, "Salad"));
            //MenuItems.Add(new Item("New York Strip (Add-on)", 6.00f, false, "Salad"));
            //MenuItems.Add(new Item("Seared Tuna (Add-on)", 10.00f, false, "Salad"));

            //Entree, total: 6
            MenuItems.Add(new Item("Shrimp & Grits", 13.50f, false, "Entree"));
            MenuItems.Add(new Item("Sweet Tea Fried Chicken", 11.50f, false, "Entree"));
            MenuItems.Add(new Item("Caribbean Chicken", 11.50f, false, "Entree"));
            MenuItems.Add(new Item("Grilled Pork Chops", 11.00f, false, "Entree"));
            MenuItems.Add(new Item("New York Strip Steak", 17.00f, true, "Entree"));
            MenuItems.Add(new Item("Seared Tuna*", 15.00f, true, "Entree"));

            //J's Favorites, total: 3
            MenuItems.Add(new Item("Captain Crunch Chicken Tenders", 11.50f, false, "J's Favorites"));
            MenuItems.Add(new Item("Shock Top Grouper Fingers", 11.50f, false, "J's Favorites"));
            MenuItems.Add(new Item("Mac & Cheese Bar", 8.50f, true, "J's Favorites"));
            // Toppings: Pepper Jack Cheese, Cheddar Cheese, Swiss Cheese, Mozzarella Cheese, Goat Cheese. $0.50 Each: Bacon, Broccoli. Mushrooms, Grilled Onions, Jalapenos, Spinach, Tomatoes.
            //MenuItems.Add(new Item("Bacon", 0.50f, false, "Mac & Cheese Bar"));
            //MenuItems.Add(new Item("Broccoli", 0.50f, false, "Mac & Cheese Bar"));
            //MenuItems.Add(new Item("Mushrooms", 0.50f, false, "Mac & Cheese Bar"));
            //MenuItems.Add(new Item("Grilled Onions", 0.50f, false, "Mac & Cheese Bar"));
            //MenuItems.Add(new Item("Jalapenos", 0.50f, false, "Mac & Cheese Bar"));
            //MenuItems.Add(new Item("Spinach", 0.50f, false, "Mac & Cheese Bar"));
            //MenuItems.Add(new Item("Tomatoes", 0.50f, false, "Mac & Cheese Bar"));

            //Protein, total: 8
            MenuItems.Add(new Item("Captain Crunch Chicken", 3.00f, false, "Protein"));
            MenuItems.Add(new Item("Roasted Chicken", 3.00f, false, "Protein"));
            MenuItems.Add(new Item("Pulled pork", 3.00f, false, "Protein"));
            MenuItems.Add(new Item("New York Strip*", 6.00f, false, "Protein"));
            MenuItems.Add(new Item("Grilled Shrimp", 6.00f, false, "Protein"));
            MenuItems.Add(new Item("Fried Shrimp", 6.00f, false, "Protein"));
            MenuItems.Add(new Item("Black Forest Ham", 2.50f, false, "Protein"));
            MenuItems.Add(new Item("Sliced Turkey Breast", 2.50f, false, "Protein"));

            //Sides, total: 14
            MenuItems.Add(new Item("Curly Fries", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Wing Chips", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Sweet Potato Fries", 4.00f, false, "Sides"));
            MenuItems.Add(new Item("Creamy Cabbage Slaw", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Adluh Cheese Grits", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Mashed Potatoes", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Mac & Cheese", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Spicy Mac & Cheese", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Bacon Mac & Cheese", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Broccoli", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Seasonal Vegetables", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Baked Beans", 2.50f, false, "Sides"));
            MenuItems.Add(new Item("Fried Okra", 4.00f, false, "Sides"));
            MenuItems.Add(new Item("Soup or Side Salad", 5.00f, true, "Sides"));

            //Sandwich, total: 9
            MenuItems.Add(new Item("Grilled Cheese", 5.50f, true, "Sandwich"));
            MenuItems.Add(new Item("100% Beef Hot Dog", 5.50f, true, "Sandwich"));
            MenuItems.Add(new Item("Chicken BLT&A", 10.00f, false, "Sandwich"));
            MenuItems.Add(new Item("Cordon Bleu", 11.00f, false, "Sandwich"));
            MenuItems.Add(new Item("Philly", 13.50f, true, "Sandwich"));
            MenuItems.Add(new Item("Pulled Pork", 9.50f, true, "Sandwich"));
            MenuItems.Add(new Item("Club", 10.00f, false, "Sandwich"));
            MenuItems.Add(new Item("Meatball Sub", 10.00f, true, "Sandwich"));
            MenuItems.Add(new Item("Po Boy", 11.50f, false, "Sandwich"));

            //Wrap, total: 4
            MenuItems.Add(new Item("Club Wrap", 10.00f, false, "Wrap"));
            MenuItems.Add(new Item("Chicken BLT&A Wrap", 10.00f, false, "Wrap"));
            MenuItems.Add(new Item("Veggie Wrap", 10.00f, false, "Wrap"));
            MenuItems.Add(new Item("Chicken Caesar Wrap", 10.00f, false, "Wrap"));

            //Burger, total: 6
            MenuItems.Add(new Item("J’s Burger", 10.00f, true, "Burger"));
            MenuItems.Add(new Item("Bacon Cheeseburger", 11.00f, true, "Burger"));
            MenuItems.Add(new Item("Mushroom Swiss Burger", 11.00f, true, "Burger"));
            MenuItems.Add(new Item("Carolina Burger", 11.00f, true, "Burger"));
            MenuItems.Add(new Item("Portobello Burger (V)", 8.50f, false, "Burger"));
            MenuItems.Add(new Item("Vegan Boca Burger (V)", 10.50f, false, "Burger"));

            //Beverage, total: 14
            MenuItems.Add(new Item("Coffee", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Sweet Tea", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Unsweet Tea", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Coke", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Diet Coke", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Sprite", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Mr. Pibb", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Ginger Ale", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Barq’s Root Beer (Can)", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Bottled Water", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Lemonade", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Chocolate Milk", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Milk", 2.00f, false, "Beverage"));
            MenuItems.Add(new Item("Orange Juice", 2.00f, false, "Beverage"));

        }
        public Item[] GetArrayOfCategory(string Category)
        {
            Item[] ArrayOfItems = new Item[14];
            int Counter = 0;
            foreach (Item I in MenuItems)
            {
                if (I.GetCategory() == Category)
                {
                    ArrayOfItems[Counter++] = I;
                }
            }
            return ArrayOfItems;
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