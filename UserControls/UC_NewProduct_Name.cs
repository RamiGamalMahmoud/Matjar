using System;
using System.Windows.Forms;
using DataAccessLayer;
using System.Data;

namespace UserControls
{
    public partial class UC_NewProduct_Name : UserControl
    {
        DBHandler db;
        public UC_NewProduct_Name()
        {
            InitializeComponent();
        }

        public void Start(DataTable categories)
        {
            if (db == null) db = new DBHandler();

            this.combo_categories.BindingContext = new BindingContext();
            this.combo_categories.DisplayMember = "category";
            this.combo_categories.ValueMember = "id";
            this.combo_categories.DataSource = categories;

            LoadCategoryProducts();

        }
        private void LoadCategoryProducts()
        {
            this.combo_existed_products_names.DataSource = db.ExecuteSQL(string.Format("SELECT product_name FROM products_names WHERE category_id = {0} ORDER BY product_name",
                this.combo_categories.SelectedValue.ToString())).ColumnToArray(0);
        }
        private void combo_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategoryProducts();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_new_product_name.Text))
            {
                MessageBox.Show("حقل فارغ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_new_product_name.Focus();
                return;
            }


            string sql = string.Format("INSERT INTO products_names VALUES (NULL, '{0}', '{1}')",
                text_new_product_name.Text,
                this.combo_categories.SelectedValue.ToString());
            if (db.ExecuteNonQuery(sql) == "Constraint")
            {
                MessageBox.Show("هذا الاسم موجود بالفعل !", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_new_product_name.Focus();
                text_new_product_name.SelectAll();
                return;
            }
            (new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipText = "تم الحفظ بنجاح",
            }).ShowBalloonTip(1000);
            LoadCategoryProducts();
        }
    }
}
