using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UC_SearchTable : UserControl
    {
        DataAccessLayer.DBHandler db;
        public UC_SearchTable()
        {
            InitializeComponent();
        }

        public void Start()
        {
            if (db == null) db = new DataAccessLayer.DBHandler();
        }

        public void search(string text)
        {
            string search_query = string.Format(@"
SELECT  products.category_id AS category_id,
        categories.category AS category_name,
        products.product_id,
        products_names.product_name,
        units.unit AS unit_name,
        units.id AS unit_id,
        products.selling_price,
        products.amount

FROM products
JOIN categories ON products.category_id = categories.id
JOIN units ON products.unit_id = units.id
JOIN products_names ON products.product_name_id = products_names.product_name_id 
WHERE products_names.product_name LIKE '%{0}%'
ORDER BY category_id, products_names.product_name, products.selling_price


", text.Trim());
            dgv_all_products.DataSource = db.ExecuteSQL(search_query);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Width = 0;
            this.Height = 0;
        }

        private void dgv_all_products_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }

            else if ( e.KeyCode == Keys.Tab)
            {
                text_amount.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void text_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }

            else if (e.KeyCode == Keys.Tab)
            {
                //dgv_all_products.Focus();
                dgv_all_products.CurrentRow.Selected = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
