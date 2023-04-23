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

        /*protected override void OnPaint(PaintEventArgs Event)
        {
            Graphics GraphicalUnit = Event.Graphics;
            Pen Black = new Pen(new SolidBrush(Color.Black));
            GraphicalUnit.DrawLine(Black, 640, 0, 640, 720);
            GraphicalUnit.DrawLine(Black, 641, 0, 641, 720);
            base.OnPaint(Event);
        }*/
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
                    Subtotal += PriceOfI;
                    if (PriceOfI < 10) Prices += "0";
                    if ((int)(PriceOfI * 100) / (int)PriceOfI > 100) Prices += PriceOfI + "0\n";
                    else Prices += I.GetCost() + ".00\n";
                }
            }
            OrderItemNames.Text = Names;
            OrderItemPrices.Text = Prices;
            float TipTotal1 = Subtotal * 0.15f;
            float TipTotal2 = Subtotal * 0.2f;
            string Tip1 = "0.00";
            string Tip2 = "0.00";
            if (Subtotal > 0)
            {
                if ((int)(TipTotal1 * 100) / (int)TipTotal1 > 100) Tip1 = TipTotal1 + "0";
                else Tip1 = TipTotal1 + ".00";
                if ((int)(TipTotal2 * 100) / (int)TipTotal2 > 100) Tip2 = TipTotal2 + "0";
                else Tip2 = TipTotal2 + ".00";
            }
            TipDisplay.Text = "Tip (15%): $" + Tip1 + "\nTip (20%): $" + Tip2;
        }
        internal void DisplaySubMenuPanel()
        {
            SubMenuPanel.Controls.Add(CustomizationMenu);
            CustomizationMenu.ScreenPointer(this);
            //CustomizationMenu.Show();
        }

        public void SetTable(Table NewTable)
        {
            this.CurrentTable = NewTable;
            if (!CurrentTable.HasOrder()) CurrentTable.NewOrder();
            SetOrder(CurrentTable.GetOrder());
            CurrentOrders.Add(GetOrder());
            SetOrderLabelDisplay();
            CurrentTable.ChangeTableStatus("Occupied");
            DiningRoomDisplay.ShowActiveStatusTables();
        }
        public void SetOrder(Order NewOrder)
        {
            CurrentOrder = NewOrder;
            CustomizationMenu.SetOrder(CurrentOrder);
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
            DiningRoomDisplay.ShowActiveStatusTables();
        }

        private void ToCategories_Click(object sender, EventArgs e)
        {
            DisplaySubMenuPanel();
        }

        private void ToOrderDisplayScreen_Click(object sender, EventArgs e)
        {
            if (!CurrentOrder.GetStatus())
            {
                CurrentTable.ChangeTableStatus("Needs Attention");
                DiningRoomDisplay.ShowActiveStatusTables();
                DiningRoomDisplay.Show();
                Hide();
            }
            else
            {

            }
        }
    }
}
