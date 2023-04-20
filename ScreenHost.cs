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

namespace Sprint_2_Group_1_1
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
        private DiningRoom KitchenOrderDisplay;

        //Constructor
        internal ScreenHost()
        {
            InitializeComponent();
            //Temp Code
            EmployeeList.Add(new Employee("John", 1234));
            EmployeeList.Add(new Employee("Adam", 4321));
            Manager Dave = new Manager(EmployeeList, "Dave1234", "1234");
            CurrentManager = Dave;
            EmployeeLogin = new EmployeeLoginScreen(Dave);
            EmployeeMenu = new MenuForEmployee();
            KitchenOrderDisplay = new DiningRoom();
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
            EmployeeMenu.ScreenPointer2(KitchenOrderDisplay);
            KitchenOrderDisplay.ScreenPointer(EmployeeMenu);
            //To add a new screen, you need the pointers to the screens that screen interacts with
            //NextScreenToAdd.NSTAScreenPointer1(ScreenToPointTo);
            //ScreenToPointTo.STPTScreenPointerx(NextScreenToAdd);

            DisplayPanel.Controls.Add(EmployeeLogin);
            DisplayPanel.Controls.Add(EmployeeMenu);
            EmployeeMenu.Hide();
            DisplayPanel.Controls.Add(KitchenOrderDisplay);
            KitchenOrderDisplay.Hide();

            //To add a new screen, you need to add it to the panel displayed on ScreenHost
            //DisplayPanel.Controls.Add(NextScreenToAdd);
            //NextScreenToAdd.Hide(); //So it does not show up instead of the login screen to begin with
        }
    }
}
