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
        }

        internal void DisplaySubMenuPanel()
        {
            SubMenuPanel.Controls.Add(CustomizationMenu);
            CustomizationMenu.Show();
        }

        public void SetTable(Table NewTable)
        {
            this.CurrentTable = NewTable;
            if (CurrentTable.HasOrder())
            {
                SetOrder(CurrentTable.GetOrder());
                CurrentOrders.Add(GetOrder());
            }
            else
            {
                CurrentTable.NewOrder();
                SetOrder(CurrentTable.GetOrder());
                CurrentOrders.Add(GetOrder());
            }
        }
        public void SetOrder(Order NewOrder)
        {
            CurrentOrder = NewOrder;
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
    }
}
