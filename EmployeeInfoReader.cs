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
    public partial class EmployeeInfoReader : UserControl
    {
        /// <summary>
        /// Attributes
        ///  FilePath (private string)
        ///  EmployeeLogin (private pointer to an object of type EmployeeLoginScreen)
        ///  EmployeeList (private List containing Employee objects)
        ///  CurrentManager (private pointer object of type Manager)
        /// </summary>
        private string FilePath;
        private EmployeeLoginScreen EmployeeLogin;
        private List<Employee> EmployeeList;
        private Manager CurrentManager;

        /// <summary>
        /// EmployeeInfoReader Constructor
        /// </summary>
        public EmployeeInfoReader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Points to specified object of type EmployeeLoginScreen named Pointer, allowing screen transitions
        /// </summary>
        /// <param name="Pointer"></param>
        public void ScreenPointer(EmployeeLoginScreen Pointer)
        {
            this.EmployeeLogin = Pointer;
        }

        /// <summary>
        /// Adds the interation between the GUI button and the functionality for the Submit Button object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                FilePath = Filename.Text;
                if (FilePath.StartsWith("\""))
                {
                    FilePath = FilePath.Substring(1, FilePath.Length - 2);
                }
                if (FilePath == null) throw new IOException("Filepath cannot be null");
                string[] AllLines = File.ReadAllLines(FilePath);
                string Category = "";
                string Name = "";
                int Password = 0;
                bool AssigningTables = false;
                List<string> TablesToAssign = new List<string>();
                EmployeeList = new List<Employee>();
                for (int i = 0; i < AllLines.Length; i++)
                {
                    string Dataline = AllLines[i];
                    if (Dataline.Equals("End"))
                    {
                        AssigningTables = false;
                        if (Category.Equals("wait"))
                        {
                            Waiter W = new Waiter(Name, Password);
                            W.AssignTables(true, TablesToAssign.ToArray());
                            EmployeeList.Add(W);
                        }
                        else if (Category.Equals("host"))
                        {
                            Host H = new Host(Name, Password);
                            H.AssignTables(true, TablesToAssign.ToArray());
                            EmployeeList.Add(H);
                        }
                        else if (Category.Equals("bus"))
                        {
                            Busboy B = new Busboy(Name, Password);
                            B.AssignTables(true, TablesToAssign.ToArray());
                            EmployeeList.Add(B);
                        }
                        else
                        {
                            EmployeeList.Add(new Cook(Name, Password));
                        }
                        TablesToAssign.Clear();
                    }
                    else if (!AssigningTables)
                    {
                        string[] DataLineSeparated = Dataline.Split(",");
                        if (DataLineSeparated[0].ToLower().Equals("cook"))
                        {
                            Category = DataLineSeparated[0].ToLower();
                            Name = DataLineSeparated[1];
                            Password = Convert.ToInt32(DataLineSeparated[2]);
                        }
                        else if (DataLineSeparated[0].ToLower().Equals("wait") || DataLineSeparated[0].ToLower().Equals("host") || DataLineSeparated[0].ToLower().Equals("bus"))
                        {
                            Category = DataLineSeparated[0].ToLower();
                            Name = DataLineSeparated[1];
                            Password = Convert.ToInt32(DataLineSeparated[2]);
                            AssigningTables = true;
                        }
                    }
                    else TablesToAssign.Add(Dataline);
                } 
                CurrentManager = new Manager(EmployeeList, "TEST1234", "1234");
                string Names = "";
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    Names += EmployeeList[i] + "|";
                }
                EmployeeLogin.SetManager(CurrentManager);
                EmployeeLogin.Show();
                Hide();
            }
            catch (IOException IOE)
            {
                WhereFile.Text = "Error: " + IOE.Message;
            }
        }

        /// <summary>
        /// Creates the Employee objects that are specified in the employee information document
        /// </summary>
        /// <param name="Role"></param>
        /// <param name="Name"></param>
        /// <param name="Password"></param>
        /// <param name="TablesAssigned"></param>
        /// <returns></returns>
        private Employee CreateEmployee(string Role, string Name, int Password, List<string> TablesAssigned)
        {
            if (Password > 9999 || Password < 0000)
            {
                throw new Exception("Employee password is invalid for: " + Name);
            }
            if (Name == null || Name.Equals(""))
            {
                throw new Exception("Employee name is invalid, please revise.");
            }
            if (Role.Equals("Wait"))
            {
                Waiter W = new Waiter(Name, Password);
                W.AssignTables(true, TablesAssigned.ToArray());
                return W;
            }
            else if (Role.Equals("Cook"))
            {
                Cook C = new Cook(Name, Password);
                return C;
            }
            else if (Role.Equals("Host"))
            {
                Host H = new Host(Name, Password);
                return H;
            }
            else if (Role.Equals("Bus"))
            {
                Busboy B = new Busboy(Name, Password);
                return B;
            }
            throw new Exception("Employee role is invalid for: " + Name);
        }

        /// <summary>
        /// Adds the interaction between the GUI textbox and the functionality for the Filename Textbox object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filename_TextChanged(object sender, EventArgs e)
        {
            FilePath = Filename.Text;
        }
    }
}
