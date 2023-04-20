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
        private UserControl MainMenu;
        public DiningRoom()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu.Show();
        }

        public void ScreenPointer(UserControl Screen)
        {
            MainMenu = Screen;
        }
    }
}
