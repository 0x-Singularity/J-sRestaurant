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
        //Attributes
        private List<Employee> EmployeeList = new List<Employee>();
        private Manager CurrentManager;
        private EmployeeLoginScreen EmployeeLogin;
        private MenuForEmployee EmployeeMenu;
        private DiningRoom DiningRoomDisplay;
        private OrderOverview OrderOverview;
        private CurrentOrderDisplay CurrentOrderDisplay;
        private CustomizationMenu CustomizationMenu;
        private EmployeeInfoReader EmployeeInfoReader;

        //Constructor
        internal ScreenHost()
        {
            InitializeComponent();
            //Temp Code

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

            //Cook 1
            Cook C1 = new Cook("Mark", 4444);
            EmployeeList.Add(C1);
            //End of Temp Code

            Manager Dave = new Manager(EmployeeList, "Dave1234", "1234");
            CurrentManager = Dave;
            EmployeeLogin = new EmployeeLoginScreen(Dave);
            EmployeeMenu = new MenuForEmployee();
            DiningRoomDisplay = new DiningRoom();
            OrderOverview = new OrderOverview();
            CurrentOrderDisplay = new CurrentOrderDisplay();
            CustomizationMenu = new CustomizationMenu();
            EmployeeInfoReader = new EmployeeInfoReader();
        }

        //Loads the screen
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

            DiningRoomDisplay.Hide();
            EmployeeMenu.Hide();
            OrderOverview.Hide();
            CurrentOrderDisplay.Hide();

            //To add a new screen, you need to add it to the panel displayed on ScreenHost
            //DisplayPanel.Controls.Add(NextScreenToAdd);
            //NextScreenToAdd.Hide(); //So it does not show up instead of the login screen to begin with
        }
    }
}
