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
        private FloorStaff CurrentEmployee;
        private Table[] ListOfAssignedTables;
        private Table[] AllTables = new Table[28];
        private Button[] TableButtons = new Button[28];
        public DiningRoom()
        {
            InitializeComponent();
            FillAllTablesAndButtons();
        }
        private void FillAllTablesAndButtons()
        {
            AllTables[0] = new Table("Clean", "Table1A");
            AllTables[1] = new Table("Clean", "Table2A");
            AllTables[2] = new Table("Clean", "Table3A");
            AllTables[3] = new Table("Clean", "Table4A");
            AllTables[4] = new Table("Clean", "Table5A");
            AllTables[5] = new Table("Clean", "Table6A");
            AllTables[6] = new Table("Clean", "Table1B");
            AllTables[7] = new Table("Clean", "Table2B");
            AllTables[8] = new Table("Clean", "Table3B");  
            AllTables[9] = new Table("Clean", "Table4B");
            AllTables[10] = new Table("Clean", "Table5B");
            AllTables[11] = new Table("Clean", "Table6B");
            AllTables[12] = new Table("Clean", "Table5C");
            AllTables[13] = new Table("Clean", "Table6C");
            AllTables[14] = new Table("Clean", "Table5D");
            AllTables[15] = new Table("Clean", "Table6D");
            AllTables[16] = new Table("Clean", "Table1E");
            AllTables[17] = new Table("Clean", "Table2E");
            AllTables[18] = new Table("Clean", "Table3E");
            AllTables[19] = new Table("Clean", "Table4E");
            AllTables[20] = new Table("Clean", "Table5E");
            AllTables[21] = new Table("Clean", "Table6E");
            AllTables[22] = new Table("Clean", "Table1F");
            AllTables[23] = new Table("Clean", "Table2F");
            AllTables[24] = new Table("Clean", "Table3F");
            AllTables[25] = new Table("Clean", "Table4F");
            AllTables[26] = new Table("Clean", "Table5F");
            AllTables[27] = new Table("Clean", "Table6F");
            TableButtons[0] = TableA1;
            TableButtons[1] = TableA2;
            TableButtons[2] = TableA3;
            TableButtons[3] = TableA4;
            TableButtons[4] = TableA5;
            TableButtons[5] = TableA6;
            TableButtons[6] = TableB1;
            TableButtons[7] = TableB2;
            TableButtons[8] = TableB3;
            TableButtons[9] = TableB4;
            TableButtons[10] = TableB5;
            TableButtons[11] = TableB6;
            TableButtons[12] = TableC5;
            TableButtons[13] = TableC6;
            TableButtons[14] = TableD5;
            TableButtons[15] = TableD6;
            TableButtons[16] = TableE2;
            TableButtons[17] = TableE2;
            TableButtons[18] = TableE3;
            TableButtons[19] = TableE4;
            TableButtons[20] = TableE5;
            TableButtons[21] = TableE6;
            TableButtons[22] = TableF1;
            TableButtons[23] = TableF2;
            TableButtons[24] = TableF3;
            TableButtons[25] = TableF4;
            TableButtons[26] = TableF5;
            TableButtons[27] = TableF6;
        }

        internal void SetEmployee(FloorStaff NewEmployee)
        {
            CurrentEmployee = NewEmployee;
            ListOfAssignedTables = CurrentEmployee.GetAssignedTables();
            //GreyOutUnassignedTables();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu.Show();
        }

        internal void ScreenPointer(MenuForEmployee Screen)
        {
            MainMenu = Screen;
        }

        internal void ScreenPointer2(OrderOverview OrderOverview)
        {
            this.OrderOverview = OrderOverview;
        }

        private bool ContainedInAssignedTables(string TableIDToCheck)
        {
            for (int i = 0; i < ListOfAssignedTables.Length; i++)
            {
                if (TableIDToCheck == ListOfAssignedTables[i].GetTableID())
                {
                    return true;
                }
            }
            return false;
        }

        private void GreyOutUnassignedTables()
        {
            if (!ContainedInAssignedTables("Table1A"))
            {
                TableA1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2A"))
            {
                TableA2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3A"))
            {
                TableA3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4A"))
            {
                TableA4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5A"))
            {
                TableA5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6A"))
            {
                TableA6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table1B"))
            {
                TableB1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2B"))
            {
                TableB2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3B"))
            {
                TableB3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4B"))
            {
                TableB4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5B"))
            {
                TableB5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6B"))
            {
                TableB6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5C"))
            {
                TableC5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6C"))
            {
                TableC6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5D"))
            {
                TableD5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6D"))
            {
                TableD6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table1E"))
            {
                TableE1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2E"))
            {
                TableE2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3E"))
            {
                TableE3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4E"))
            {
                TableE4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5E"))
            {
                TableE5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6E"))
            {
                TableE6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table1F"))
            {
                TableF1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2F"))
            {
                TableF2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3F"))
            {
                TableF3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4F"))
            {
                TableF4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5F"))
            {
                TableF5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6F"))
            {
                TableF6.BackColor = Color.DarkGray;
            }
            ShowActiveTableStatuses();
        }
        private void ShowActiveTableStatuses()
        {
            if (!ContainedInAssignedTables("Table1A"))
            {
                TableA1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2A"))
            {
                TableA2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3A"))
            {
                TableA3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4A"))
            {
                TableA4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5A"))
            {
                TableA5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6A"))
            {
                TableA6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table1B"))
            {
                TableB1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2B"))
            {
                TableB2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3B"))
            {
                TableB3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4B"))
            {
                TableB4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5B"))
            {
                TableB5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6B"))
            {
                TableB6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5C"))
            {
                TableC5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6C"))
            {
                TableC6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5D"))
            {
                TableD5.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table6D"))
            {
                TableD6.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table1E"))
            {
                TableE1.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table2E"))
            {
                TableE2.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table3E"))
            {
                TableE3.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table4E"))
            {
                TableE4.BackColor = Color.DarkGray;
            }
            if (!ContainedInAssignedTables("Table5E"))
            {
                if (AllTables[20].GetCurrentStatus() == "Clean")
                {
                    TableE5.BackColor = Color.LimeGreen;
                }
                else if (AllTables[20].GetCurrentStatus() == "Occupied")
                {
                    TableE5.BackColor = Color.Yellow;
                }
                else
                {
                    TableE5.BackColor = Color.Red;
                }
            }
            if (!ContainedInAssignedTables("Table6E"))
            {
                if (AllTables[21].GetCurrentStatus() == "Clean")
                {
                    TableE6.BackColor = Color.LimeGreen;
                }
                else if (AllTables[21].GetCurrentStatus() == "Occupied")
                {
                    TableE6.BackColor = Color.Yellow;
                }
                else
                {
                    TableE6.BackColor = Color.Red;
                }
            }
            if (!ContainedInAssignedTables("Table1F"))
            {
                if (AllTables[22].GetCurrentStatus() == "Clean")
                {
                    TableF1.BackColor = Color.LimeGreen;
                }
                else if (AllTables[22].GetCurrentStatus() == "Occupied")
                {
                    TableF1.BackColor = Color.Yellow;
                }
                else
                {
                    TableF1.BackColor = Color.Red;
                }
            }
            if (!ContainedInAssignedTables("Table2F"))
            {
                if (AllTables[23].GetCurrentStatus() == "Clean")
                {
                    TableF2.BackColor = Color.LimeGreen;
                }
                else if (AllTables[23].GetCurrentStatus() == "Occupied")
                {
                    TableF2.BackColor = Color.Yellow;
                }
                else
                {
                    TableF5.BackColor = Color.Red;
                }
            }
            if (!ContainedInAssignedTables("Table3F"))
            {
                if (AllTables[24].GetCurrentStatus() == "Clean")
                {
                    TableF3.BackColor = Color.LimeGreen;
                }
                else if (AllTables[24].GetCurrentStatus() == "Occupied")
                {
                    TableF3.BackColor = Color.Yellow;
                }
                else
                {
                    TableF3.BackColor = Color.Red;
                }
            }
            if (ContainedInAssignedTables("Table4F"))
            {
                if (AllTables[25].GetCurrentStatus() == "Clean")
                {
                    TableF4.BackColor = Color.LimeGreen;
                }
                else if (AllTables[25].GetCurrentStatus() == "Occupied")
                {
                    TableF4.BackColor = Color.Yellow;
                }
                else
                {
                    TableF4.BackColor = Color.Red;
                }
            }
            if (ContainedInAssignedTables("Table5F"))
            {
                if (AllTables[26].GetCurrentStatus() == "Clean")
                {
                    TableF5.BackColor = Color.LimeGreen;
                }
                else if (AllTables[26].GetCurrentStatus() == "Occupied")
                {
                    TableF5.BackColor = Color.Yellow;
                }
                else
                {
                    TableF5.BackColor = Color.Red;
                }
            }
            if (ContainedInAssignedTables("Table6F"))
            {
                if (AllTables[27].GetCurrentStatus() == "Clean")
                {
                    TableF6.BackColor = Color.LimeGreen;
                }
                else if (AllTables[27].GetCurrentStatus() == "Occupied")
                {
                    TableF6.BackColor = Color.Yellow;
                }
                else
                {
                    TableF6.BackColor = Color.Red;
                }
            }
        }
        private void TableA1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1A"))
            {
                Hide();
                OrderOverview.Show();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[0]);
            }
        }

        private void TableA2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2A"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[1]);
            }
        }

        private void TableA3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3A"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[2]);
            }
        }

        private void TableA4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4A"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[3]);
            }
        }

        private void TableA5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5A"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[4]);
            }
        }

        private void TableA6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6A"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[5]);
            }
        }

        private void TableB1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1B"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[6]);
            }
        }

        private void TableB2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2B"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[7]);
            }
        }

        private void TableB3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3B"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[8]);
            }
        }

        private void TableB4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4B"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[9]);
            }
        }

        private void TableB5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5B"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[10]);
            }
        }

        private void TableB6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6B"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[11]);
            }
        }

        private void TableC5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5C"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[12]);
            }
        }

        private void TableC6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6C"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[13]);
            }
        }

        private void TableD5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5D"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[14]);
            }
        }

        private void TableD6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6D"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[15]);
            }
        }

        private void TableE1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1E"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[16]);
            }
        }

        private void TableE2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2E"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[17]);
            }
        }

        private void TableE3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3E"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[18]);
            }
        }

        private void TableE4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4E"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[19]);
            }
        }

        private void TableE5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5E"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[20]);
            }
        }

        private void TableE6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6E"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[21]);
            }
        }

        private void TableF1_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table1F"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[22]);
            }
        }

        private void TableF2_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table2F"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[23]);
            }
        }

        private void TableF3_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table3F"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[24]);
            }
        }

        private void TableF4_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table4F"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[25]);
            }
        }

        private void TableF5_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table5F"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[26]);
            }
        }

        private void TableF6_Click(object sender, EventArgs e)
        {
            if (ContainedInAssignedTables("Table6F"))
            {
                OrderOverview.Show();
                Hide();
                OrderOverview.SetCurrentEmployee(CurrentEmployee);
                OrderOverview.SetTable(AllTables[27]);
            }
        }
    }
}
