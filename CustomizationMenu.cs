using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint_2_GUI_Group1_1
{
    internal partial class CustomizationMenu : UserControl
    {
        private OrderOverview OrderOverview;
        private Menu CurrentMenu = new Menu();
        private Order CurrentOrder;
        private Item[] CategoryItems;
        private byte MenuDisplay;
        //MenuDisplay
        //0 = Categories
        //1 = Entrees
        //2 = Sides
        //3 = Sandwiches
        //4 = Wraps
        //5 = Beverages
        //6 = Seating
        private Button[] ButtonList;
        public CustomizationMenu()
        {
            InitializeComponent();
            ButtonList = new Button[5];
            ButtonList[0] = CustomizationButton1;
            ButtonList[1] = CustomizationButton2;
            ButtonList[2] = CustomizationButton3;
            ButtonList[3] = CustomizationButton4;
            ButtonList[4] = CustomizationButton5;
            Categories();
        }

        internal void ScreenPointer(OrderOverview Pointer)
        {
            OrderOverview = Pointer;
        }

        internal void SetOrder(Order NewOrder)
        {
            CurrentOrder = NewOrder;
        }
        private void Categories()
        {
            MenuDisplay = 0;
            MenuLabel.Text = "Categories";
            ButtonList[0].Text = "Entrees";
            ButtonList[1].Text = "Sides";
            ButtonList[2].Text = "Sandwiches";
            ButtonList[3].Text = "Wraps";
            ButtonList[4].Text = "Beverages";
            ButtonList[4].Show();
        }

        private void SetButtonTexts(string CategoryName)
        {
            MenuLabel.Text = CategoryName;
            CategoryItems = CurrentMenu.GetArrayOfCategory(CategoryName);
            for (int i = 0; i < CategoryItems.Length; i++)
            {
                ButtonList[i].Text = CategoryItems[i].GetName();
            }
        }
        
        private void Entrees()
        {
            SetButtonTexts("Entree");
            MenuDisplay = 1;
        }

        private void Sides()
        {
            SetButtonTexts("Side");
            MenuDisplay = 2;
        }

        private void Sandwiches()
        {
            SetButtonTexts("Sandwich");
            MenuDisplay = 3;
        }

        private void Wraps()
        {
            SetButtonTexts("Wrap");
            MenuDisplay = 4;
        }


        private void Beverages()
        {
            SetButtonTexts("Beverage");
            MenuDisplay = 5;
        }

        private void Seating()
        {
            MenuDisplay = 6;
            MenuLabel.Text = "For what seat?";
            for (int i = 1; i < 5; i++)
            {
                ButtonList[i - 1].Text = "" + i;
            }
        }

        private void CustomizationButton1_Click(object sender, EventArgs e)
        {
            switch (MenuDisplay)
            {
                case 0:
                    Entrees();
                    ButtonList[4].Hide();
                    break;
                case 6:
                    Categories();
                    break;
                default:
                    CurrentOrder.AddItemToOrder(CategoryItems[0]);
                    OrderOverview.SetOrderLabelDisplay();
                    Seating();
                    break;
            }
        }

        private void CustomizationButton2_Click(object sender, EventArgs e)
        {
            switch (MenuDisplay)
            {
                case 0:
                    Sides();
                    ButtonList[4].Hide();
                    break;
                case 6:
                    Categories();
                    break;
                default:
                    CurrentOrder.AddItemToOrder(CategoryItems[1]);
                    OrderOverview.SetOrderLabelDisplay();
                    Seating();
                    break;
            }
        }

        private void CustomizationButton3_Click(object sender, EventArgs e)
        {
            switch (MenuDisplay)
            {
                case 0:
                    Sandwiches();
                    ButtonList[4].Hide();
                    break;
                case 6:
                    Categories();
                    break;
                default:
                    CurrentOrder.AddItemToOrder(CategoryItems[2]);
                    OrderOverview.SetOrderLabelDisplay();
                    Seating();
                    break;
            }
        }

        private void CustomizationButton4_Click(object sender, EventArgs e)
        {
            switch (MenuDisplay)
            {
                case 0:
                    Wraps();
                    ButtonList[4].Hide();
                    break;
                case 6:
                    Categories();
                    break;
                default:
                    CurrentOrder.AddItemToOrder(CategoryItems[3]);
                    OrderOverview.SetOrderLabelDisplay();
                    Seating();
                    break;
            }
        }

        private void CustomizationButton5_Click(object sender, EventArgs e)
        {
            switch (MenuDisplay)
            {
                case 0:
                    Beverages();
                    ButtonList[4].Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
