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
    internal partial class OrderOverview : UserControl
    {
        private DiningRoom DiningRoomDisplay;
        private MenuForEmployee EmployeeMenu;
        private CustomizationMenu CustomizationMenu;
        private Employee CurrentEmployee;
        private Table CurrentTable;
        private Order CurrentOrder;
        internal List<Order> CurrentOrders = new List<Order>();
        public OrderOverview()
        {
            InitializeComponent();
            BackgroundOrderOverview.Paint += new PaintEventHandler(BackgroundOrderOverview_Paint);
        }
        protected void BackgroundOrderOverview_Paint(object Sender, PaintEventArgs Event)
        {
            var GraphicalUnit = Event.Graphics;
            Pen Pen = new Pen(new SolidBrush(Color.White));
            GraphicalUnit.DrawLine(Pen, 640, 0, 640, 720);
            GraphicalUnit.DrawLine(Pen, 641, 0, 641, 720);
            GraphicalUnit.DrawLine(Pen, 0, 24, 640, 24);
            GraphicalUnit.DrawLine(Pen, 0, 25, 640, 25);
        }
        public void ScreenPointer(DiningRoom DRD)
        {
            DiningRoomDisplay = DRD;
        }

        public void ScreenPointer2(MenuForEmployee EmployeeMenu)
        {
            this.EmployeeMenu = EmployeeMenu;
        }

        public void ScreenPointer3(CustomizationMenu Pointer)
        {
            CustomizationMenu = Pointer;
            DisplaySubMenuPanel();
        }

        internal void SetOrderLabelDisplay()
        {
            List<Item> CurrentOrderItems = CurrentOrder.GetList();
            string Names = "";
            string Prices = "";
            float Subtotal = 0.0f;
            if (CurrentOrder.GetList() != null)
            {
                foreach (Item I in CurrentOrderItems)
                {
                    Names += I.GetName() + "\n";
                    float PriceOfI = I.GetCost();
                    if (PriceOfI < 10) Prices += "0";
                    Prices += MakeNumberActAsMoney(PriceOfI + "") + "\n";
                    Subtotal += PriceOfI;
                }
            }
            OrderItemNames.Text = Names;
            OrderItemPrices.Text = Prices;
            float TipTotal1 = Subtotal * 0.15f;
            float TipTotal2 = Subtotal * 0.2f;
            float Tax = Subtotal * 0.07f;
            float Total = Subtotal + Tax;
            string Tip1 = MakeNumberActAsMoney(TipTotal1 + "");
            string Tip2 = MakeNumberActAsMoney(TipTotal2 + "");
            TipDisplay.Text = "Tip (15%): $" + Tip1 + "\nTip (20%): $" + Tip2;
            TotalDisplay.Text = "Subtotal: " + MakeNumberActAsMoney(Subtotal + "");
            TotalDisplay.Text += "\nTax:          " + MakeNumberActAsMoney(Tax + "");
            TotalDisplay.Text += "\nTotal:       " + MakeNumberActAsMoney(Total + "");
        }

        private string MakeNumberActAsMoney(string UnformattedNumber)
        {
            bool HasDecimal = false;
            int i = 0;
            for (; i < UnformattedNumber.Length; i++)
            {
                if (UnformattedNumber[i] == '.')
                {
                    HasDecimal = true;
                    break;
                }
            }
            if (HasDecimal)
            {
                int LengthAfterDecimal = UnformattedNumber.Length - i;
                string NumberBeforeHolder = UnformattedNumber.Substring(0, i);
                string Holder = UnformattedNumber.Substring(i, LengthAfterDecimal);
                if (LengthAfterDecimal < 3)
                {
                    return NumberBeforeHolder + Holder + "0";
                }
                else if (LengthAfterDecimal > 3)
                {
                    return NumberBeforeHolder + Holder.Substring(0, 3);
                }
            }
            else return UnformattedNumber + ".00";
            return UnformattedNumber;
        }
        internal void DisplaySubMenuPanel()
        {
            SubMenuPanel.Controls.Add(CustomizationMenu);
            CustomizationMenu.ScreenPointer(this);
        }

        public void SetTable(Table NewTable)
        {
            this.CurrentTable = NewTable;
            TableDisplay.Text = CurrentTable.GetTableID();
            if (!CurrentTable.HasOrder()) CurrentTable.NewOrder();
            SetOrder(CurrentTable.GetOrder());
            SetOrderLabelDisplay();
            CurrentTable.ChangeTableStatus(2);
            DiningRoomDisplay.ShowActiveStatusTables();
        }
        
        public void SetCurrentTableStatus()
        {
            CurrentTable.ChangeTableStatus(3);
        }

        public void ChangeButton()
        {
            SendToKitchen.Text = "Clean Table";
            CustomizationMenu.Hide();
        }

        public void SetOrder(Order NewOrder)
        {
            CurrentOrder = NewOrder;
            CustomizationMenu.SetOrder(CurrentOrder);
            CurrentOrder.SetTable(CurrentTable);
            OrderNumberDisplay.Text = "Order #: " + CurrentOrder.GetID();
            EmployeeNameLabel.Text = "Employee Name: " + CurrentEmployee.GetEmployeeName();
        }

        public Order GetOrder()
        {
            return CurrentOrder;
        }

        public void SetCurrentEmployee(Employee NewEmployee)
        {
            CurrentEmployee = NewEmployee;
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeMenu.Show();
        }

        private void ToDiningRoom_Click(object sender, EventArgs e)
        {
            Hide();
            DiningRoomDisplay.Show();
        }

        private void ToCategories_Click(object sender, EventArgs e)
        {
            DisplaySubMenuPanel();
        }

        private void SendToKitchen_Click(object sender, EventArgs e)
        {
            if (CurrentOrder.GetStatus() == "Complete") 
            {
                CurrentTable.ChangeTableStatus(1);
                CurrentTable.SetNullOrder();
                DiningRoomDisplay.ShowActiveStatusTables();
                SendToKitchen.Text = "Send and Pay";
                CustomizationMenu.Show();
                DiningRoomDisplay.Show();
                Hide();
            }
            else
            {
                CurrentOrders.Add(CurrentOrder);
                CurrentOrder.ChangeOrderStatus();
                DiningRoomDisplay.SetStatusOfTableAtIndex(CurrentTable.GetIndex(), 2);
                DiningRoomDisplay.ShowActiveStatusTables();
                DiningRoomDisplay.Show();
                Hide();
            }
        }
    }
}
