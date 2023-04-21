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
        //Temp code?
        private List<Employee> EmployeeList = new List<Employee>();
        private List<Table> Tables = new List<Table>();
        //End of Temp Code

        //Attributes
        private Manager CurrentManager;
        private EmployeeLoginScreen EmployeeLogin;
        private MenuForEmployee EmployeeMenu;
        private DiningRoom DiningRoomDisplay;
        private OrderOverview OrderOverview;

        //Constructor
        internal ScreenHost()
        {
            InitializeComponent();
            //Temp Code
            Waiter W1 = new Waiter("John", 1111);
            Waiter W2 = new Waiter("Adam", 2222);
            Waiter W3 = new Waiter("Andrew", 3333);
            Table[] AssignedTablesW1 = new Table[9];
            Table[] AssignedTablesW2 = new Table[10];
            Table[] AssignedTablesW3 = AssignedTablesW1;
            AssignedTablesW1[0] = new Table("Clean", "Table1A");
            AssignedTablesW1[1] = new Table("Clean", "Table2A");
            AssignedTablesW1[2] = new Table("Clean", "Table3A");
            AssignedTablesW1[3] = new Table("Clean", "Table4A");
            AssignedTablesW1[4] = new Table("Clean", "Table5A");
            AssignedTablesW1[5] = new Table("Clean", "Table1B");
            AssignedTablesW1[6] = new Table("Clean", "Table2B");
            AssignedTablesW1[7] = new Table("Clean", "Table3B");
            AssignedTablesW1[8] = new Table("Clean", "Table4B");

            AssignedTablesW2[0] = new Table("Clean", "Table6A");
            AssignedTablesW2[1] = new Table("Clean", "Table5B");
            AssignedTablesW2[2] = new Table("Clean", "Table6B");
            AssignedTablesW2[3] = new Table("Clean", "Table5C");
            AssignedTablesW2[4] = new Table("Clean", "Table6C");
            AssignedTablesW2[5] = new Table("Clean", "Table5D");
            AssignedTablesW2[6] = new Table("Clean", "Table6D");
            AssignedTablesW2[7] = new Table("Clean", "Table5E");
            AssignedTablesW2[8] = new Table("Clean", "Table6E");
            AssignedTablesW2[9] = new Table("Clean", "Table6F");

            AssignedTablesW3[0] = new Table("Clean", "Table1E");
            AssignedTablesW3[1] = new Table("Clean", "Table2E");
            AssignedTablesW3[2] = new Table("Clean", "Table3E");
            AssignedTablesW3[3] = new Table("Clean", "Table4E");
            AssignedTablesW3[4] = new Table("Clean", "Table1F");
            AssignedTablesW3[5] = new Table("Clean", "Table2F");
            AssignedTablesW3[6] = new Table("Clean", "Table3F");
            AssignedTablesW3[7] = new Table("Clean", "Table4F");
            AssignedTablesW3[8] = new Table("Clean", "Table5F");
            W1.AssignTables(true, AssignedTablesW1);
            W2.AssignTables(true, AssignedTablesW2);
            W3.AssignTables(true, AssignedTablesW3);
            EmployeeList.Add(W1);
            EmployeeList.Add(W2);
            EmployeeList.Add(W3);
            Manager Dave = new Manager(EmployeeList, "Dave1234", "1234");
            CurrentManager = Dave;
            EmployeeLogin = new EmployeeLoginScreen(Dave);
            EmployeeMenu = new MenuForEmployee();
            DiningRoomDisplay = new DiningRoom();
            OrderOverview = new OrderOverview();
            //End of Temp Code
        }

        //Paints the rectangles on the screen
        protected override void OnPaint(PaintEventArgs Event)
        {
            Graphics GraphicalUnit = Event.Graphics;
            SolidBrush TopColor = new SolidBrush(Color.Ivory);
            SolidBrush MiddleColor = new SolidBrush(Color.DarkGray);
            SolidBrush BottomColor = new SolidBrush(Color.LightSlateGray);
            Rectangle Top = new Rectangle(0, 0, 1280, 240);
            Rectangle Middle = new Rectangle(0, 241, 1280, 240);
            Rectangle Bottom = new Rectangle(0, 481, 1280, 240);
            GraphicalUnit.FillRectangle(TopColor, Top);
            GraphicalUnit.FillRectangle(MiddleColor, Middle);
            GraphicalUnit.FillRectangle(BottomColor, Bottom);
            base.OnPaint(Event);
        }

        //Loads the screen
        private void ScreenHost_Load(object sender, EventArgs e)
        {
            EmployeeLogin.ScreenPointer(EmployeeMenu);
            EmployeeMenu.ScreenPointer(EmployeeLogin);
            EmployeeMenu.ScreenPointer2(DiningRoomDisplay);
            DiningRoomDisplay.ScreenPointer(EmployeeMenu);
            OrderOverview.ScreenPointer(DiningRoomDisplay);
            DiningRoomDisplay.ScreenPointer2(OrderOverview);
            OrderOverview.ScreenPointer2(EmployeeMenu);
            //To add a new screen, you need the pointers to the screens that screen interacts with
            //NextScreenToAdd.NSTAScreenPointer1(ScreenToPointTo);
            //ScreenToPointTo.STPTScreenPointerx(NextScreenToAdd);

            DisplayPanel.Controls.Add(EmployeeLogin);
            DisplayPanel.Controls.Add(EmployeeMenu);
            EmployeeMenu.Hide();
            DisplayPanel.Controls.Add(DiningRoomDisplay);
            DiningRoomDisplay.Hide();
            DisplayPanel.Controls.Add(OrderOverview);
            OrderOverview.Hide();

            //To add a new screen, you need to add it to the panel displayed on ScreenHost
            //DisplayPanel.Controls.Add(NextScreenToAdd);
            //NextScreenToAdd.Hide(); //So it does not show up instead of the login screen to begin with
        }
    }
}
