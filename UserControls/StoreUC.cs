using DataAccessLayer;
using System.Windows.Forms;
using Repos;


namespace UserControls
{
    public partial class StoreUC : UserControl
    {
        private ProductsRepo repo;
        public StoreUC()
        {
            this.InitializeComponent();
            this.dgv_store.DoubleBuffered(true);
            this.dgv_store.AutoGenerateColumns = false;
        }

        public void Start()
        {
            this.repo = new ProductsRepo();
            this.dgv_store.DataSource = this.repo.GetAllProducts();
        }
    }
}
