using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;


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
