namespace ClothingStore
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            dgvRecent.Rows.Add("#1042", "Sara A.", "$85", "Nov 04");
            dgvRecent.Rows.Add("#1041", "Omar K.", "$120", "Nov 04");
            dgvRecent.Rows.Add("#1040", "Walk-in", "$42", "Nov 03");
            dgvLow.Rows.Add("Black hoodie M", "2");
            dgvLow.Rows.Add("Slim jeans 32", "4");
            dgvLow.Rows.Add("Floral dress S", "5");
        }
    }
}
