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
            this.InitializeComponent();
            this.CategoriesTable = this.db.ExecuteSQL("SELECT id, category FROM categories");
            this.UnitsTable = this.db.ExecuteSQL("SELECT id, unit FROM units ORDER BY unit");
            this.uC_Add_Product_Full1.Start(this.CategoriesTable, this.UnitsTable);
        }

    }
}
