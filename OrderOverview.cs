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
        private Employee CurrentEmployee;
        private Table CurrentTable;
        private Order CurrentOrder;
        public OrderOverview()
        {
            InitializeComponent();
        }
        
        public void ScreenPointer(DiningRoom DRD)
        {
            DiningRoomDisplay = DRD;
        }

        public void ScreenPointer2(MenuForEmployee EmployeeMenu)
        {
            this.EmployeeMenu = EmployeeMenu;
        }

        public void SetTable(Table NewTable)
        {
            this.CurrentTable = NewTable;
            SetOrder(new Order());
        }
        public void SetOrder(Order NewOrder)
        {
            CurrentOrder = NewOrder;
            OrderNumberDisplay.Text = "Order #:" + CurrentOrder.GetID();
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
    }
}
