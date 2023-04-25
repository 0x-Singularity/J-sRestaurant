﻿using System;
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
    public partial class CurrentOrderDisplay : UserControl
    {
        private OrderOverview OrderOverview;
        private MenuForEmployee EmployeeMenu;
        private List<Label> FIFOs = new List<Label>();
        public CurrentOrderDisplay()
        {
            InitializeComponent();
            FIFOs.Add(FIFO1);
            FIFOs.Add(FIFO2);
            FIFOs.Add(FIFO3);
            FIFOs.Add(FIFO4);
            FIFOs.Add(FIFO5);
        }
        internal void ScreenPointer(OrderOverview Pointer)
        {
            OrderOverview = Pointer;
        }
        internal void ScreenPointer2(MenuForEmployee Pointer)
        {
            EmployeeMenu = Pointer;
        }
        internal void DisplayOnFIFOs()
        {
            List<Order> OrderList = OrderOverview.CurrentOrders;
            for (int i = 0; i < 5; i++)
            {
                FIFOs[i].Text = "Order #: ";
                if (OrderList.Count - i > 0)
                {
                    FIFOs[i].Text += OrderList[i].GetID();
                    FIFOs[i].Show();
                }
                else FIFOs[i].Hide();
            }
            if (OrderList.Count > 0)
            {
                List<Item> CurrentOrderItems = OrderList[0].GetList();
                string Names = "Order #: " + OrderList[0].GetID() + "\n";
                if (CurrentOrderItems.Count > 0)
                {
                    foreach (Item I in CurrentOrderItems)
                    {
                        Names += I.GetName() + "\n";
                    }
                    FirstOrder.Text = Names;
                }
                else
                {
                    FirstOrder.Text = "There are no current orders!";
                }
            }
            else
            {
                FirstOrder.Text = "There are no current orders!";
            }
            if (EmployeeMenu.GetCurrentEmployee() is Cook)
            {
                FIFO1CompleteOrder.Enabled = true;
            }
            else
            {
                FIFO1CompleteOrder.Enabled = false;
            }
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            EmployeeMenu.Show();
            Hide();
        }

        private void FIFO1CompleteOrder_Click(object sender, EventArgs e)
        {
            List<Order> OrderList = OrderOverview.CurrentOrders;
            if (OrderList.Count > 0)
            {
                OrderList[0].ChangeOrderStatus();
                OrderList[0].ChangeOrderTableStatus();
                OrderList.RemoveAt(0);
            }
            DisplayOnFIFOs();
        }
    }
}