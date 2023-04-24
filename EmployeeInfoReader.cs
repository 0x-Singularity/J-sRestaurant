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
        private EmployeeLoginScreen ELS;
        public EmployeeInfoReader()
        {
            InitializeComponent();
        }

        public void ScreenPointer(EmployeeLoginScreen ELS)
        {
            this.ELS = ELS;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Read document from Filename
            Hide();
            ELS.Show();
        }

        private void Filename_TextChanged(object sender, EventArgs e)
        {
            FilePath = Filename.Text;
        }
    }
}
