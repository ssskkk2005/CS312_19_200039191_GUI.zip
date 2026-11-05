namespace ClothingStore
{
    public partial class frmMain : Form
    {
        private readonly frmLogin _login;
        private bool _loggingOut;

        public frmMain() : this(null) { }

        public frmMain(frmLogin login)
        {
            InitializeComponent();
            _login = login;
            btnDashboard.Click += (s, e) => ShowPage(new ucDashboard(), btnDashboard);
            btnProducts.Click += (s, e) => ShowPage(new ucProducts(), btnProducts);
            btnSizesColors.Click += (s, e) => ShowPage(new ucSizesColors(), btnSizesColors);
            btnInventory.Click += (s, e) => ShowPage(new ucInventory(), btnInventory);
            btnSales.Click += (s, e) => ShowPage(new ucSales(), btnSales);
            btnReports.Click += (s, e) => ShowPage(new ucReports(), btnReports);
            btnLogout.Click += (s, e) => { _loggingOut = true; _login?.Show(); Close(); };
            FormClosed += (s, e) => { if (!_loggingOut) Application.Exit(); };
            ShowPage(new ucDashboard(), btnDashboard);
        }

        private void ShowPage(UserControl page, Button active)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
            foreach (Control c in pnlSidebar.Controls)
                if (c is Button b && b != btnLogout)
                    b.BackColor = (b == active) ? Color.White : Color.FromArgb(235, 243, 255);
        }
    }
}
