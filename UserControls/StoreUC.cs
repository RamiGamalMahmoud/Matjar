using DataAccessLayer;
using System.Windows.Forms;


namespace UserControls
{
    public partial class StoreUC : UserControl
    {
        private DBHandler db;
        public StoreUC()
        {
            InitializeComponent();
            dgv_store.DoubleBuffered(true);
            dgv_store.AutoGenerateColumns = false;
        }

        public void Start()
        {
            if (db == null)
            {
                db = new DBHandler();

                dgv_store.DataSource = DBHelber.GetAllProducts("0");
            }
        }
    }
}
