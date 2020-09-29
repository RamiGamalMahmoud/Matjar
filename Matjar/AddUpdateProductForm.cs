using DataAccessLayer;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Matjar
{
    public partial class AddUpdateProductForm : Form
    {
        public DataTable CategoriesTable { get; private set; }
        public DataTable UnitsTable { get; private set; }
        DBHandler db = new DBHandler();

        public AddUpdateProductForm()
        {
            InitializeComponent();
            CategoriesTable = db.ExecuteSQL("SELECT id, category FROM categories");
            UnitsTable = db.ExecuteSQL("SELECT id, unit FROM units ORDER BY unit");
            uC_Add_Product_Full1.Start(CategoriesTable, UnitsTable);
        }

    }
}
