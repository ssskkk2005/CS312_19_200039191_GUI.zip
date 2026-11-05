namespace ClothingStore
{
    public partial class ucInventory : UserControl
    {
        public ucInventory()
        {
            InitializeComponent();
            dgvInventory.Rows.Add("Black hoodie", "M", "Black", "2", "Very low");
            dgvInventory.Rows.Add("Slim jeans", "32", "Blue", "4", "Low");
            dgvInventory.Rows.Add("Floral dress", "S", "Red", "25", "In stock");
            dgvInventory.Rows.Add("Kids tee", "6Y", "White", "40", "In stock");
        }
    }
}
