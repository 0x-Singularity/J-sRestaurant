using Sprint_2_GUI_Group1_1;
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
    public partial class ScreenHost : Form
    {
        /// <summary>
        /// Attributes:
        ///  EmployeeLogin (private pointer object of type EmployeeLoginScreen)
        ///  EmployeeMenu (private pointer object of type MenuForEmployee)
        ///  DiningRoomDisplay (private pointer object of type DiningRoom)
        ///  OrderOverview (private pointer object of type OrderOverview)
        ///  CurrentOrderDisplay (private pointer object of type CurrentOrderDisplay)
        ///  CustomizationMenu (private pointer object of type CustomizationMenu)
        ///  EmployeeInfoReader (private pointer object of type EmployeeInfoReader)
        /// </summary>
        private EmployeeLoginScreen EmployeeLogin;
        private MenuForEmployee EmployeeMenu;
        private DiningRoom DiningRoomDisplay;
        private OrderOverview OrderOverview;
        private CurrentOrderDisplay CurrentOrderDisplay;
        private CustomizationMenu CustomizationMenu;
        private EmployeeInfoReader EmployeeInfoReader;
        //To create a new screen, you need a pointer
        //private Screen NewScreen;

        /// <summary>
        /// ScreenHost Constructor
        /// </summary>
        internal ScreenHost()
        {
            InitializeComponent();
            /*//Temp Code

            //Waiter 1
            Waiter W1 = new Waiter("John", 1111);
            string[] AssignedTablesW1 = new string[9];
            AssignedTablesW1[0] = "Table1A";
            AssignedTablesW1[1] = "Table2A";
            AssignedTablesW1[2] = "Table3A";
            AssignedTablesW1[3] = "Table4A";
            AssignedTablesW1[4] = "Table5A";
            AssignedTablesW1[5] = "Table1B";
            AssignedTablesW1[6] = "Table2B";
            AssignedTablesW1[7] = "Table3B";
            AssignedTablesW1[8] = "Table4B";
            W1.AssignTables(true, AssignedTablesW1);
            EmployeeList.Add(W1);

            //Waiter 2
            Waiter W2 = new Waiter("Adam", 2222);
            string[] AssignedTablesW2 = new string[10];
            AssignedTablesW2[0] = "Table6A";
            AssignedTablesW2[1] = "Table5B";
            AssignedTablesW2[2] = "Table6B";
            AssignedTablesW2[3] = "Table5C";
            AssignedTablesW2[4] = "Table6C";
            AssignedTablesW2[5] = "Table5D";
            AssignedTablesW2[6] = "Table6D";
            AssignedTablesW2[7] = "Table5E";
            AssignedTablesW2[8] = "Table6E";
            AssignedTablesW2[9] = "Table6F";
            W2.AssignTables(true, AssignedTablesW2);
            EmployeeList.Add(W2);

            //Waiter 3
            Waiter W3 = new Waiter("Andrew", 3333);
            string[] AssignedTablesW3 = new string[9];
            AssignedTablesW3[0] = "Table1E";
            AssignedTablesW3[1] = "Table2E";
            AssignedTablesW3[2] = "Table3E";
            AssignedTablesW3[3] = "Table4E";
            AssignedTablesW3[4] = "Table1F";
            AssignedTablesW3[5] = "Table2F";
            AssignedTablesW3[6] = "Table3F";
            AssignedTablesW3[7] = "Table4F";
            AssignedTablesW3[8] = "Table5F";
            W3.AssignTables(true, AssignedTablesW3);
            EmployeeList.Add(W3);

            //Waiter 4 (to do bug fixing)
            Waiter W4 = new Waiter("TEST EMPLOYEE", 9999);
            string[] AssignedTablesW4 = new string[28];
            AssignedTablesW4[0] = "Table1A";
            AssignedTablesW4[1] = "Table2A";
            AssignedTablesW4[2] = "Table3A";
            AssignedTablesW4[3] = "Table4A";
            AssignedTablesW4[4] = "Table5A";
            AssignedTablesW4[5] = "Table1B";
            AssignedTablesW4[6] = "Table2B";
            AssignedTablesW4[7] = "Table3B";
            AssignedTablesW4[8] = "Table4B";
            AssignedTablesW4[9] = "Table6A";
            AssignedTablesW4[10] = "Table5B";
            AssignedTablesW4[11] = "Table6B";
            AssignedTablesW4[12] = "Table5C";
            AssignedTablesW4[13] = "Table6C";
            AssignedTablesW4[14] = "Table5D";
            AssignedTablesW4[15] = "Table6D";
            AssignedTablesW4[16] = "Table5E";
            AssignedTablesW4[17] = "Table6E";
            AssignedTablesW4[18] = "Table6F";
            AssignedTablesW4[19] = "Table1E";
            AssignedTablesW4[20] = "Table2E";
            AssignedTablesW4[21] = "Table3E";
            AssignedTablesW4[22] = "Table4E";
            AssignedTablesW4[23] = "Table1F";
            AssignedTablesW4[24] = "Table2F";
            AssignedTablesW4[25] = "Table3F";
            AssignedTablesW4[26] = "Table4F";
            AssignedTablesW4[27] = "Table5F";
            W4.AssignTables(true, AssignedTablesW4);
            EmployeeList.Add(W4);

            //Cook 1
            Cook C1 = new Cook("Mark", 4444);
            EmployeeList.Add(C1);
            //End of Temp Code

            Manager M1 = new Manager(EmployeeList, "TEST1234", "1234");
            CurrentManager = M1;*/
            EmployeeLogin = new EmployeeLoginScreen();
            EmployeeMenu = new MenuForEmployee();
            DiningRoomDisplay = new DiningRoom();
            OrderOverview = new OrderOverview();
            CurrentOrderDisplay = new CurrentOrderDisplay();
            CustomizationMenu = new CustomizationMenu();
            EmployeeInfoReader = new EmployeeInfoReader();

            //To add a new screen, you need the object to be created and assigned.
            //NewScreen = new Screen()
        }

        /// <summary>
        /// Loads the ScreenHost object's screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenHost_Load(object sender, EventArgs e)
        {
            EmployeeLogin.ScreenPointer(EmployeeMenu);
            EmployeeMenu.ScreenPointer(EmployeeLogin);
            EmployeeMenu.ScreenPointer2(DiningRoomDisplay);
            EmployeeMenu.ScreenPointer3(CurrentOrderDisplay);
            DiningRoomDisplay.ScreenPointer(EmployeeMenu);
            DiningRoomDisplay.ScreenPointer2(OrderOverview);
            DiningRoomDisplay.ScreenPointer3(CurrentOrderDisplay);
            OrderOverview.ScreenPointer2(EmployeeMenu);
            OrderOverview.ScreenPointer(DiningRoomDisplay);
            OrderOverview.ScreenPointer3(CustomizationMenu);
            CurrentOrderDisplay.ScreenPointer(OrderOverview);
            CurrentOrderDisplay.ScreenPointer2(EmployeeMenu);
            CustomizationMenu.ScreenPointer(OrderOverview);
            EmployeeInfoReader.ScreenPointer(EmployeeLogin);
            
            //To add a new screen, you need the pointers to the screens that screen interacts with
            //NextScreenToAdd.NSTAScreenPointer1(ScreenToPointTo);
            //ScreenToPointTo.STPTScreenPointerx(NextScreenToAdd);

            DisplayPanel.Controls.Add(EmployeeLogin);
            DisplayPanel.Controls.Add(EmployeeMenu);
            DisplayPanel.Controls.Add(DiningRoomDisplay);
            DisplayPanel.Controls.Add(OrderOverview);
            DisplayPanel.Controls.Add(CurrentOrderDisplay);
            DisplayPanel.Controls.Add(EmployeeInfoReader);

            DiningRoomDisplay.Hide();
            EmployeeMenu.Hide();
            OrderOverview.Hide();
            CurrentOrderDisplay.Hide();
            EmployeeLogin.Hide();

            //To add a new screen, you need to add it to the panel displayed on ScreenHost
            //DisplayPanel.Controls.Add(NextScreenToAdd);
            //NextScreenToAdd.Hide(); //So it does not show up instead of the login screen to begin with
        }
    }
}
