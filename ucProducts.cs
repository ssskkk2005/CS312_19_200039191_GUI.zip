namespace ClothingStore
{
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
            dgvProducts.Rows.Add("101", "Black hoodie", "Men", "$45");
            dgvProducts.Rows.Add("102", "Slim jeans", "Men", "$55");
            dgvProducts.Rows.Add("103", "Floral dress", "Women", "$60");
            dgvProducts.Rows.Add("104", "Kids tee", "Kids", "$15");
        }
    }
}
