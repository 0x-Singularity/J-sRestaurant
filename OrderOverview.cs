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
        /// <summary>
        /// Attributes:
        ///  DiningRoomDisplay (private pointer object of type DiningRoom)
        ///  EmployeeMenu (private pointer object of type MenuForEmployee)
        ///  CustomizationMenu (private pointer object of type Customization Menu)
        ///  CurrentEmployee (private pointer object of type Employee)
        ///  CurrentTable (private pointer object of type Table)
        ///  CurrentOrder (private pointer object of type Order)
        ///  CurrentOrders (internal pointer List containing Order objects
        /// </summary>
        private DiningRoom DiningRoomDisplay;
        private MenuForEmployee EmployeeMenu;
        private CustomizationMenu CustomizationMenu;
        private Employee CurrentEmployee;
        private Table CurrentTable;
        private Order CurrentOrder;
        internal List<Order> CurrentOrders = new List<Order>();

        /// <summary>
        /// OrderOverview Constructor
        /// </summary>
        public OrderOverview()
        {
            InitializeComponent();
            BackgroundOrderOverview.Paint += new PaintEventHandler(BackgroundOrderOverview_Paint);
        }

        /// <summary>
        /// Adds the lines to the screen to differentiate the areas of the screen
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Event"></param>
        protected void BackgroundOrderOverview_Paint(object Sender, PaintEventArgs Event)
        {
            var GraphicalUnit = Event.Graphics;
            Pen Pen = new Pen(new SolidBrush(Color.White));
            GraphicalUnit.DrawLine(Pen, 640, 0, 640, 720);
            GraphicalUnit.DrawLine(Pen, 641, 0, 641, 720);
            GraphicalUnit.DrawLine(Pen, 0, 24, 640, 24);
            GraphicalUnit.DrawLine(Pen, 0, 25, 640, 25);
        }

        /// <summary>
        /// Points to specified object of type DiningRoom named Pointer, allowing screen transitions
        /// </summary>
        /// <param name="DRD"></param>
        public void ScreenPointer(DiningRoom Pointer)
        {
            DiningRoomDisplay = Pointer;
        }

        /// <summary>
        /// Points to specified object of type MenuForEmployee named Pointer, allowing screen transitions
        /// </summary>
        /// <param name="EmployeeMenu"></param>
        public void ScreenPointer2(MenuForEmployee Pointer)
        {
            this.EmployeeMenu = Pointer;
        }

        /// <summary>
        /// Points to specified object of type CustomizationMenu named Pointer, allowing screen transitions.
        /// Displays this screen on the allocated Panel object of the OrderOverview screen.
        /// </summary>
        /// <param name="Pointer"></param>
        public void ScreenPointer3(CustomizationMenu Pointer)
        {
            CustomizationMenu = Pointer;
            DisplaySubMenuPanel();
        }

        /// <summary>
        /// Updates the order Label objects Text with accurate information.
        /// </summary>
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

        /// <summary>
        /// Takes in a string and formats it how US currency is formatted: XX.XX
        /// </summary>
        /// <param name="UnformattedNumber"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds the controls of and displays the CustomizationMenu object screen
        /// </summary>
        internal void DisplaySubMenuPanel()
        {
            SubMenuPanel.Controls.Add(CustomizationMenu);
            CustomizationMenu.ScreenPointer(this);
        }

        /// <summary>
        /// Sets the object CurrentTable to the passed object
        /// </summary>
        /// <param name="NewTable"></param>
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
        
        /// <summary>
        /// Sets the CurrentTable object's status to 3, which means "Needs Attention"
        /// </summary>
        public void SetCurrentTableStatus()
        {
            CurrentTable.ChangeTableStatus(3);
        }

        /// <summary>
        /// changes the Send and Pay button named SendToKitchen to "Clean Table" and hides the CustomizationMenu object screen
        /// </summary>
        public void ChangeButton()
        {
            SendToKitchen.Text = "Clean Table";
            CustomizationMenu.Hide();
        }

        /// <summary>
        /// Sets the Current order to the passed object.
        /// Passes the passed in object to the CustomizationMenu object's SetOrder method.
        /// Sets the table of the CurrentOrder object to the CurrentTable object
        /// Sets the Text of the OrderNumberDisplay Label object to "Order #: " and the CurrentOrder object's Order ID
        /// Sets the Text of the EmployeeNameLabel Label object to "Employee Name: " and the CurrentEmployee object's Name
        /// </summary>
        /// <param name="NewOrder"></param>
        public void SetOrder(Order NewOrder)
        {
            CurrentOrder = NewOrder;
            CustomizationMenu.SetOrder(CurrentOrder);
            CurrentOrder.SetTable(CurrentTable);
            OrderNumberDisplay.Text = "Order #: " + CurrentOrder.GetID();
            EmployeeNameLabel.Text = "Employee Name: " + CurrentEmployee.GetEmployeeName();
        }

        /// <summary>
        /// Returns the CurrentOrder object
        /// </summary>
        /// <returns></returns>
        public Order GetOrder()
        {
            return CurrentOrder;
        }

        /// <summary>
        /// Sets the CurrentEmployee pointer to the passed in object
        /// </summary>
        /// <param name="NewEmployee"></param>
        public void SetCurrentEmployee(Employee NewEmployee)
        {
            CurrentEmployee = NewEmployee;
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the MenuForEmployee object's screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeMenu.Show();
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the DiningRoom object's screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToDiningRoom_Click(object sender, EventArgs e)
        {
            Hide();
            DiningRoomDisplay.Show();
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the CustomizationMenu object's screen through the use of the DisplaySubMenuPanel method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToCategories_Click(object sender, EventArgs e)
        {
            DisplaySubMenuPanel();
        }

        /// <summary>
        /// Adds the functionality to the GUI button to submit the CurrentOrder object to the kitchen
        /// Adds the functionality to the GUI button the virtually "Clean Table"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
