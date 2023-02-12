namespace Bondoc_Tudor_Database_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MainMenu main_menu = new MainMenu();
            main_menu.Show();
            this.Hide();
        }
    }
}