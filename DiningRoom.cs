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
    public partial class DiningRoom : UserControl
    {
        private MenuForEmployee MainMenu;
        private OrderOverview OrderOverview;
        private CurrentOrderDisplay CurrentOrderDisplay;
        private FloorStaff CurrentEmployee;
        private string[] ListOfAssignedTables;
        private Table[] AllTables = new Table[28];
        internal Button[] TableButtons = new Button[28];
        public DiningRoom()
        {
            InitializeComponent();
            FillAllTablesAndButtons();
        }
        internal void ScreenPointer(MenuForEmployee Screen)
        {
            MainMenu = Screen;
        }

        internal void ScreenPointer2(OrderOverview OrderOverview)
        {
            this.OrderOverview = OrderOverview;
            this.OrderOverview.SetCurrentEmployee(CurrentEmployee);
        }

        internal void ScreenPointer3(CurrentOrderDisplay Pointer)
        {
            CurrentOrderDisplay = Pointer;
        }

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

        internal void SetEmployee(FloorStaff NewEmployee)
        {
            CurrentEmployee = NewEmployee;
            ListOfAssignedTables = CurrentEmployee.GetAssignedTables();
            GreyOutUnassignedTables();
        }


        //Find a table in assigned tables using a TableID
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

        // GUI Button Methods Contained Below

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu.Show();
        }

        private void ToCurrentOrders_Click(object sender, EventArgs e)
        {
            CurrentOrderDisplay.Show();
            CurrentOrderDisplay.DisplayOnFIFOs();
            Hide();
        }

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

        private void TableA1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1A"))
            {
                Hide();
                TableClickFunction(0);
            }
        }

        private void TableA2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(4);
            }
        }

        private void TableA3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(8);
            }
        }

        private void TableA4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(12);
            }
        }

        private void TableA5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(16);
            }
        }

        private void TableA6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6A"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(22);
            }
        }

        private void TableB1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(1);
            }
        }

        private void TableB2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(5);
            }
        }

        private void TableB3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(9);
            }
        }

        private void TableB4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(13);
            }
        }

        private void TableB5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(17);
            }
        }

        private void TableB6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6B"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(23);
            }
        }

        private void TableC5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5C"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(18);
            }
        }

        private void TableC6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6C"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(24);
            }
        }

        private void TableD5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5D"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(19);
            }
        }

        private void TableD6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6D"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(25);
            }
        }

        private void TableE1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(2);
            }
        }

        private void TableE2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(6);
            }
        }

        private void TableE3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(10);
            }
        }

        private void TableE4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(14);
            }
        }

        private void TableE5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(20);
            }
        }

        private void TableE6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6E"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(26);
            }
        }

        private void TableF1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(3);
            }
        }

        private void TableF2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(7);
            }
        }

        private void TableF3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(11);
            }
        }

        private void TableF4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(15);
            }
        }

        private void TableF5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5F"))
            {
                OrderOverview.Show();
                Hide();
                TableClickFunction(21);
            }
        }

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
