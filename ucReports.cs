namespace ClothingStore
{
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
            dgvReport.Rows.Add("Nov 02", "19", "34", "$1,180");
            dgvReport.Rows.Add("Nov 03", "21", "40", "$1,410");
            dgvReport.Rows.Add("Nov 04", "18", "31", "$1,240");
        }
    }
}
