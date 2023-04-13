namespace Sprint_2_ISWE_Group_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testing to see if this is what we need to do to change screens.
            Form2 F2 = new Form2();
            Visible = false;
            F2.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}