using System;
using System.Data;
using System.Windows.Forms;
using DataAccessLayer;

namespace UserControls
{
    public partial class UC_NewProduct : UserControl
    {
        DBHandler db;
        public UC_NewProduct()
        {
            InitializeComponent();
        }

        public void Start(DataTable categories, DataTable units)
        {
            if (db == null) db = new DBHandler();

            this.combo_categories_names.DataSource = categories;
            this.combo_categories_names.DisplayMember = "category";
            this.combo_categories_names.ValueMember = "id";
            this.combo_categories_names.BindingContext = new BindingContext();
            this.combo_categories_names.SelectedIndexChanged += combo_categories_names_SelectedIndexChanged;
            combo_categories_names_SelectedIndexChanged(this.combo_categories_names, EventArgs.Empty);


            this.combo_units.DataSource = units;
            this.combo_units.DisplayMember = "unit";
            this.combo_units.ValueMember = "id";
            this.combo_units.BindingContext = new BindingContext();
            this.combo_units.SelectedIndexChanged += combo_units_SelectIndexChanged;
            combo_units_SelectIndexChanged(this.combo_units, EventArgs.Empty);
        }

        private void combo_categories_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.combo_products_names.DataSource = db.ExecuteSQL(string.Format("SELECT product_name_id, product_name FROM products_names WHERE category_id = {0} ORDER BY product_name", this.combo_categories_names.SelectedValue.ToString()));
            this.combo_products_names.DisplayMember = "product_name";
            this.combo_products_names.ValueMember = "product_name_id";
        }

        private void combo_units_SelectIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            double selling_price, purchasing_price, profit_margin, amount;
            double.TryParse(text_amount.Text, out amount);
            double.TryParse(text_selling_price.Text, out selling_price);
            double.TryParse(text_purchasing_price.Text, out purchasing_price);
            double.TryParse(text_profit_margin.Text, out profit_margin);

            string message = "";
            //MessageArgs args = new MessageArgs();

            string sql = string.Format(@"
                INSERT INTO products 
                SELECT NULL, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}' 
                WHERE NOT EXISTS 
                ( SELECT 1 FROM products WHERE product_name_id = {4} AND category_id = {5} AND unit_id = {6} )",
                amount,
                selling_price,
                purchasing_price,
                profit_margin,
                combo_products_names.SelectedValue.ToString(),
                combo_categories_names.SelectedValue.ToString(),
                combo_units.SelectedValue.ToString());
            if (db.ExecuteNonQuery(sql) == "0")
            {

                DialogResult result = MessageBox.Show(string.Format(@"
هذا المنتج موجود بالفعل
                هل تريد اجراء تعديلات عليه ؟"), "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel) return;
                else
                {
                    // edit the product data
                    string edit_query = string.Format(@"
UPDATE  products SET 
        amount = {0},
        purchasing_price = {1},
        selling_price = {2},
        profit_margin = {3}

WHERE   product_name_id = {4}
  AND   category_id = {5}
  AND   unit_id = {6}

",
                    amount,
                    purchasing_price,
                    selling_price,
                    profit_margin,
                    combo_products_names.SelectedValue.ToString(),
                    combo_categories_names.SelectedValue.ToString(),
                    combo_units.SelectedValue.ToString());
                    db.ExecuteNonQuery(edit_query);
                    
                    message = "تم التعديل بنجاح";
                }
            }
            else
            {
                message = "تم الحفظ بنجاح";
            }
            new NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipText = message,
            }.ShowBalloonTip(1000);
        }

    }
}
