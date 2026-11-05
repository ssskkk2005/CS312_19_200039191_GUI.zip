namespace ClothingStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
            btnLogin.Click += (s, e) =>
            {
                txtPassword.Clear();
                new frmMain(this).Show();
                Hide();
            };
        }
    }
}
