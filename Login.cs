namespace Mines
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        PlaceHolderManager placeholder = new PlaceHolderManager();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Gamble gamble = new Gamble();
            gamble.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
