using System;
using System.Data;
using System.Windows.Forms;
using DataAccessLayer;

namespace Matjar
{
    public partial class FormManagement : Form
    {
        DBHandler db = new DBHandler();

        public DataTable CategoriesTable { get; private set; }
        public DataTable UnitsTable { get; set; }

        public FormManagement()
        {
            InitializeComponent();
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            uC_NewCategory1.CategoriesUpdated += ReloadData;
            uC_NewUnit1.UnitsUpdated += ReloadData;
        }

        private void LoadData()
        {
            this.LoadCategories();
            this.LoadUnits();
            this.SetUpPans();
        }

        public void ReloadData(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadCategories()
        {
            CategoriesTable = db.ExecuteSQL("SELECT id, category FROM categories");
        }

        private void LoadUnits()
        {
            UnitsTable = db.ExecuteSQL("SELECT id, unit FROM units ORDER BY unit");
        }

        private void SetUpPans()
        {
            this.uC_NewCategory1.Start(this.CategoriesTable);
            this.uC_NewUnit1.Start(this.UnitsTable);

            this.uC_NewProduct_Name1.Start(this.CategoriesTable);
            this.uC_NewProduct1.Start(this.CategoriesTable, this.UnitsTable);
            this.uC_UpdateUnitsContentsInfo1.Start(this.CategoriesTable, this.UnitsTable);
        }

    }
}
