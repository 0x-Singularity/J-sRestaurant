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
        private string FilePath;
        private EmployeeLoginScreen EmployeeLogin;
        public EmployeeInfoReader()
        {
            InitializeComponent();
        }

        public void ScreenPointer(EmployeeLoginScreen Pointer)
        {
            this.EmployeeLogin = Pointer;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Read document from Filename
            EmployeeLogin.Show();
            Hide();
        }

        private void Filename_TextChanged(object sender, EventArgs e)
        {
            FilePath = Filename.Text;
        }
    }
}
