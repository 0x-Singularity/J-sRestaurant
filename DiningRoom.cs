using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sprint_2_GUI_Group1_1
{
    public partial class DiningRoom : UserControl
    {
        /// <summary>
        /// Attributes:
        ///  MainMenu (private pointer object of type MenuForEmployee)
        ///  OrderOverview (private pointer object of type OrderOverview)
        ///  CurrentOrderDisplay (private pointer object of type CurrentOrderDisplay)
        ///  CurrentEmployee (private pointer object of type FloorStaff)
        ///  ListOfAssignedTables (private string array containing table IDs)
        ///  AllTables (private Table object array containing all Table objects)
        ///  TableButtons (private Button object array containing all Button objects for the tables)
        /// </summary>
        private MenuForEmployee MainMenu;
        private OrderOverview OrderOverview;
        private CurrentOrderDisplay CurrentOrderDisplay;
        private FloorStaff CurrentEmployee;
        private string[] ListOfAssignedTables;
        private Table[] AllTables = new Table[28];
        internal Button[] TableButtons = new Button[28];

        /// <summary>
        /// DiningRoom Constructor
        /// </summary>
        public DiningRoom()
        {
            InitializeComponent();
            FillAllTablesAndButtons();
        }

        /// <summary>
        /// Points to specified object of type MenuForEmployee named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        internal void ScreenPointer(MenuForEmployee Pointer)
        {
            MainMenu = Pointer;
        }

        /// <summary>
        /// Points to specified object of type OrderOverview named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        internal void ScreenPointer2(OrderOverview Pointer)
        {
            this.OrderOverview = Pointer;
            this.OrderOverview.SetCurrentEmployee(CurrentEmployee);
        }

        /// <summary>
        /// Points to specified object of type CurrentOrderDisplay named Pointer, allowing screen transitions.
        /// </summary>
        /// <param name="Pointer"></param>
        internal void ScreenPointer3(CurrentOrderDisplay Pointer)
        {
            CurrentOrderDisplay = Pointer;
        }

        /// <summary>
        /// Fills the AllTables array with Table objects.
        /// </summary>
        private void FillAllTablesAndButtons()
        {
            int Counter = -1;
            string Table = "Table";
            for (int y = 1; y <= 6; y++)
            {
                string Temp = Table + y;
                string Tempy = Temp;
                for (int x = 1; x <= 6; x++)
                {
                    switch (x)
                    {
                        case 1:
                            Temp += "A";
                            Counter++;
                            break;
                        case 2:
                            Temp += "B";
                            Counter++;
                            break;
                        case 3:
                            if (y < 5) continue;
                            Temp += "C";
                            Counter++;
                            break;
                        case 4:
                            if (y < 5) continue;
                            Temp += "D";
                            Counter++;
                            break;
                        case 5:
                            Temp += "E";
                            Counter++;
                            break;
                        case 6:
                            Temp += "F";
                            Counter++;
                            break;
                    }
                    AllTables[Counter] = new Table(1, Temp, Counter);
                    Temp = Tempy;
                }
            }
            TableButtons[0] = TableA1;
            TableButtons[1] = TableB1;
            TableButtons[2] = TableE1;
            TableButtons[3] = TableF1;
            TableButtons[4] = TableA2;
            TableButtons[5] = TableB2;
            TableButtons[6] = TableE2;
            TableButtons[7] = TableF2;
            TableButtons[8] = TableA3;
            TableButtons[9] = TableB3;
            TableButtons[10] = TableE3;
            TableButtons[11] = TableF3;
            TableButtons[12] = TableA4;
            TableButtons[13] = TableB4;
            TableButtons[14] = TableE4;
            TableButtons[15] = TableF4;
            TableButtons[16] = TableA5;
            TableButtons[17] = TableB5;
            TableButtons[18] = TableC5;
            TableButtons[19] = TableD5;
            TableButtons[20] = TableE5;
            TableButtons[21] = TableF5;
            TableButtons[22] = TableA6;
            TableButtons[23] = TableB6;
            TableButtons[24] = TableC6;
            TableButtons[25] = TableD6;
            TableButtons[26] = TableE6;
            TableButtons[27] = TableF6;
        }

        /// <summary>
        /// Sets CurrentEmployee pointer to passed in FloorStaff object.
        /// </summary>
        /// <param name="NewEmployee"></param>
        internal void SetEmployee(FloorStaff NewEmployee)
        {
            CurrentEmployee = NewEmployee;
            ListOfAssignedTables = CurrentEmployee.GetAssignedTables();
            GreyOutUnassignedTables();
        }


        /// <summary>
        /// Find a table in ListOfAssignedTables using a TableID.
        /// </summary>
        /// <param name="TableYX"></param>
        /// <returns></returns>
        private bool ContainedInAssignedTables(string TableYX)
        {
            for (int i = 0; i < ListOfAssignedTables.Length; i++)
            {
                if (TableYX.Equals(ListOfAssignedTables[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sets the status of the Table object at the corresponding index.
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="Status"></param>
        internal void SetStatusOfTableAtIndex(int Index, byte Status)
        {
            if (ContainedInAssignedTables(AllTables[Index].GetTableID()))
            {
                switch (AllTables[Index].GetCurrentStatus())
                {
                    case 1:
                        TableButtons[Index].BackColor = Color.Green;
                        break;
                    case 2:
                        TableButtons[Index].BackColor = Color.Yellow;
                        break;
                    case 3:
                        TableButtons[Index].BackColor = Color.Red;
                        break;
                }
                TableButtons[Index].Enabled = true;
            }
        }

        /// <summary>
        /// Greys out table Buttons that are not assigned.
        /// </summary>
        private void GreyOutUnassignedTables()
        {
            for (int i = 0; i < AllTables.Length; i++)
            {
                if (!ContainedInAssignedTables(AllTables[i].GetTableID()))
                {
                    TableButtons[i].BackColor = Color.DarkGray;
                    TableButtons[i].Enabled = false;
                }
            }
            ShowActiveStatusTables();
        }

        /// <summary>
        /// Shows the table Button objects that are assigned to the CurrentEmployee.
        /// </summary>
        internal void ShowActiveStatusTables()
        {
            for (int i = 0; i < AllTables.Length; i++)
            {
                if (ContainedInAssignedTables(AllTables[i].GetTableID()))
                {
                    switch (AllTables[i].GetCurrentStatus())
                    {
                        case 1:
                            TableButtons[i].BackColor = Color.Green;
                            break;
                        case 2:
                            TableButtons[i].BackColor = Color.Yellow;
                            break;
                        case 3:
                            TableButtons[i].BackColor = Color.Red;
                            break;
                    }
                    TableButtons[i].Enabled = true;
                }
            }
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the MainMenu object's screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu.Show();
        }

        /// <summary>
        /// Adds the functionality to the GUI button to change screens with the CurrentOrderDisplay object's screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToCurrentOrders_Click(object sender, EventArgs e)
        {
            CurrentOrderDisplay.Show();
            CurrentOrderDisplay.DisplayOnFIFOs();
            Hide();
        }

        /// <summary>
        /// Abstracted method that adds the functionality of the individual table Button objects
        /// </summary>
        /// <param name="Index"></param>
        private void TableClickFunction(int Index)
        {
            OrderOverview.Show();
            OrderOverview.SetCurrentEmployee(CurrentEmployee);
            OrderOverview.SetTable(AllTables[Index]);
            if (AllTables[Index].GetOrder() == null)
            {
                AllTables[Index].NewOrder();
                OrderOverview.SetOrder(AllTables[Index].GetOrder());
            }
            if (AllTables[Index].GetOrder().GetStatus() == "Complete")
            {
                OrderOverview.ChangeButton();
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableA1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableA1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1A"))
            {
                Hide();
                TableClickFunction(0);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableA2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableA2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(4);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableA3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableA3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(8);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableA4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableA4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(12);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableA5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableA5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(16);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableA6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableA6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(22);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableB1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableB1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(1);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableB2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableB2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(5);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableB3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableB3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(9);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableB4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableB4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(13);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableB5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableB5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(17);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableB6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableB6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(23);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableC5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableC5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5C"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(18);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableC6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableC6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6C"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(24);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableD5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableD5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5D"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(19);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableD6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableD6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6D"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(25);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableE1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableE1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(2);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableE2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableE2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(6);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableE3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableE3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(10);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableE4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableE4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(14);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableE5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableE5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(20);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableE6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableE6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(26);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableF1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableF1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(3);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableF2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableF2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(7);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableF3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableF3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(11);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableF4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableF4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(15);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableF5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableF5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(21);
            }
        }

        /// <summary>
        /// Adds the functionality of the GUI button for TableF6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TableF6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(27);
            }
        }
    }
}
