using System;
using System.Data;
using System.Windows.Forms;
using GControls;
using System.Collections.Generic;
using Models;
using System.Drawing;

namespace UserControls
{
    public partial class UC_Add_Product_Full : UserControl
    {
        private DataAccessLayer.DBHandler db;

        public UC_Add_Product_Full()
        {
            InitializeComponent();
        }

        public void Start(DataTable categories, DataTable units)
        {
            if (db == null) db = new DataAccessLayer.DBHandler();
            combo_categories.DisplayMember = "category";
            combo_categories.ValueMember = "id";
            combo_categories.DataSource = categories;

            combo_units.DisplayMember = "unit";
            combo_units.ValueMember = "id";
            combo_units.DataSource = units;

            combo_base_units.BindingContext = new System.Windows.Forms.BindingContext();
            combo_base_units.DisplayMember = "unit";
            combo_base_units.ValueMember = "id";
            combo_base_units.DataSource = units;

            combo_sub_units.DisplayMember = "unit";
            combo_sub_units.ValueMember = "id";
            combo_sub_units.DataSource = units;
            combo_sub_units.BindingContext = new System.Windows.Forms.BindingContext();

            combo_categories.SelectedValueChanged += combo_categories_SelectedValueChanged;
            combo_categories_SelectedValueChanged(combo_categories, EventArgs.Empty);

            combo_existed_products_names.SelectedValueChanged += combo_existed_products_names_SelectedValueChanged;
            combo_existed_products_names_SelectedValueChanged(combo_categories, EventArgs.Empty);
        }

        private void combo_categories_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable existed_products = DataAccessLayer.DBHelber.GetCategoryProducts(combo_categories.SelectedValue.ToString());

            combo_existed_products_names.DisplayMember = "product_name";
            combo_existed_products_names.ValueMember = "product_name_id";
            combo_existed_products_names.DataSource = existed_products;

            combo_existed_products_names_2.DisplayMember = "product_name";
            combo_existed_products_names_2.ValueMember = "product_name_id";
            combo_existed_products_names_2.DataSource = existed_products;
        }

        private void combo_existed_products_names_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_existed_products_names.SelectedValue == null) return;
            dgv_existing_products.DataSource = DataAccessLayer.DBHelber.GetProductNameData(combo_existed_products_names.SelectedValue.ToString());
            dgv_info.DataSource = DataAccessLayer.DBHelber.GetUnitsInfo(combo_existed_products_names.SelectedValue.ToString());
        }

        private void dgv_info_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SpredInfo(e.RowIndex);
        }


        private void SpredInfo(int row_index)
        {
            lbl_info_id.Text = dgv_info.Rows[row_index].Cells[0].Value.ToString();
            combo_base_units.Text = dgv_info.Rows[row_index].Cells[1].Value.ToString();
            combo_sub_units.Text = dgv_info.Rows[row_index].Cells[3].Value.ToString();
            text_contents_amount.Text = dgv_info.Rows[row_index].Cells[5].Value.ToString();
            combo_is_purchaseable.Text = dgv_info.Rows[row_index].Cells[6].Value.ToString();
        }

        private bool IsNameExisted()
        {
            return combo_existed_products_names.FindStringExact(text_new_product_name.Text) >= 0;
        }


        private bool IsNameAndUnitExisted(out Product existed_product)
        {
            // YES -> is the name and the unit, existed ?
            combo_existed_products_names.Text = text_new_product_name.Text;


            string product_query = string.Format(@"
                SELECT c.product_id
                  FROM products c
                 WHERE EXISTS (
                        SELECT 1 
                          FROM products
                         WHERE c.product_name_id = {0} AND
                               c.unit_id = {1} 
                );

                ", combo_existed_products_names.SelectedValue.ToString(),
                combo_units.SelectedValue.ToString());

            DataTable ExistedProduct = db.ExecuteSQL(product_query);
            if (ExistedProduct.Rows.Count > 0)
            {
                existed_product = new Product() { ProductID = int.Parse(ExistedProduct.Rows[0]["product_id"].ToString()) };
                return true;
            }

            else
            {
                existed_product = null;
                return false;
            }
        }

        private void UpdateProductData(Product existed_product)
        {
            List<string> old_data = new List<string>();
            List<string> new_data = new List<string>();

            new_data.Add(combo_units.Text);
            new_data.Add(text_amount.Text);
            new_data.Add(text_purchasing_price.Text);
            new_data.Add(text_selling_price.Text);
            new_data.Add(text_profit_margin.Text);

            if (new FormExistedDataMessage().ShowDialog(combo_categories.Text, existed_product, new_data) == DialogResult.OK)
            {
                string update_product_data = string.Format(@"
                    UPDATE products
                    SET unit_id = {0},
                        amount = {1},
                        purchasing_price = {2},
                        selling_price = {3},
                        profit_margin = {4}
                    WHERE product_id = {5}
                    "
                    , combo_units.SelectedValue.ToString(),
                    text_amount.Text,
                    text_purchasing_price.Text,
                    text_selling_price.Text,
                    text_profit_margin.Text,
                    existed_product.ProductID);
                db.ExecuteNonQuery(update_product_data);
            }
        }
        private void InsertNewProduct()
        {
            List<string> new_data = new List<string>();
            new_data.Add(combo_existed_products_names.Text);
            new_data.Add(combo_units.Text);
            new_data.Add(text_amount.Text);
            new_data.Add(text_purchasing_price.Text);
            new_data.Add(text_selling_price.Text);
            new_data.Add(text_profit_margin.Text);

            if (new FormExistedDataMessage().ShowDialog(combo_categories.Text, new_data) == DialogResult.OK)
            {



                string insert_into_products = string.Format(@"
                INSERT INTO products 
                (
                    product_id, 
                    amount,
                    selling_price,
                    purchasing_price,
                    profit_margin,
                    product_name_id,
                    category_id,
                    unit_id
                )

                VALUES 
                (
                    NULL,
                    '{0}',
                    '{1}',
                    '{2}',
                    '{3}',
                    '{4}',
                    '{5}',
                    '{6}'
                )",
                  text_amount.Text,
                  text_selling_price.Text,
                  text_purchasing_price.Text,
                  text_purchasing_price.Text,
                  combo_existed_products_names.SelectedValue.ToString(),
                  combo_categories.SelectedValue.ToString(),
                  combo_units.SelectedValue.ToString());
                db.ExecuteNonQuery(insert_into_products);
            }
        }
        private void UpdateProductsNames()
        {
            string insert_product_name_query = string.Format(
            "INSERT INTO products_names ( product_name_id, product_name, category_id ) VALUES ( NULL, '{0}', '{1}' )",
            text_new_product_name.Text,
            combo_categories.SelectedValue.ToString());
            db.ExecuteNonQuery(insert_product_name_query);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // حقل الاسم الجديد فارغ
            if (string.IsNullOrWhiteSpace(text_new_product_name.Text))
            {

                Product product; // اختبار ما اذا كان الاسم موجود بنفس الوحدة؟
                if (IsNameAndUnitExisted(out product))
                {
                    UpdateProductData(product); // تحديث البيانات الموجودة
                }

                else
                {
                    InsertNewProduct(); // اضافة منتج جديد بالوحدة الخاصة به و جميع بياناته
                }
                //return;
            }

            else // في حالة اذا كتب المستخد اسم منتج 
            {
                if (IsNameExisted())
                {
                    Product product;
                    if (IsNameAndUnitExisted(out product))
                    {
                        UpdateProductData(product);
                    }
                    else
                    {
                        InsertNewProduct();
                    }
                }

                else
                {
                    DialogResult update_names_message = MessageBox.Show(string.Format(

                        @"
هل تريد اضافة هذا المنتج الجديد ؟
اسم القسم : {0}
اسم المنتج : {1}"
                        , combo_categories.Text,
                        text_new_product_name.Text),
                        "اضافة منتج جديد",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);

                    if (update_names_message == DialogResult.OK)
                    {
                        UpdateProductsNames();
                        combo_categories_SelectedValueChanged(combo_categories, EventArgs.Empty);
                        combo_existed_products_names.Text = text_new_product_name.Text;
                        InsertNewProduct();
                        combo_existed_products_names_SelectedValueChanged(combo_existed_products_names, EventArgs.Empty);
                    }
                }
            }
        }


        public event EventHandler<MessageArgs> SendMessage;
        protected void OnSendMessage(MessageArgs e)
        {
            EventHandler<MessageArgs> handler = SendMessage;
            if (handler != null)
                handler(this, e);
        }

        private void check_activate_new_name_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn_add_new_product_name_Click(object sender, EventArgs e)
        {
            btn_add_new_product_name.Visible = false;
            text_new_product_name.Visible = true;
            lbl_add_new_product_name.Visible = true;
            btn_back.Visible = true;
            text_new_product_name.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_add_new_product_name.Visible = true;
            text_new_product_name.Visible = false;
            lbl_add_new_product_name.Visible = false;
            btn_back.Visible = false;
            text_new_product_name.Text = "";
        }

        private void TextBoxFocused(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.SelectAll();
        }

        private void btn_info_save_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(text_contents_amount.Text, out amount))
            {
                MessageBox.Show("لقد تم كتابة العدد بطريقة خاطئة");
                return;
            }
            if (string.IsNullOrEmpty(combo_is_purchaseable.Text))
            {
                MessageBox.Show("يرجى تحديد ما اذا كانت الوحدة الفرعية قابلة للشراء ام لا");
                return;
            }
            if (combo_base_units.Text == combo_sub_units.Text)
            {
                text_contents_amount.Text = "1";
                combo_is_purchaseable.Text = "لا";
                return;
            }

            foreach (DataGridViewRow row in dgv_info.Rows)
            {
                if (
                    combo_base_units.SelectedValue.ToString() == row.Cells["base_unit_id"].Value.ToString() &&
                    combo_sub_units.SelectedValue.ToString() == row.Cells["sub_unit_id"].Value.ToString() &&
                    text_contents_amount.Text == row.Cells["sub_unit_count"].Value.ToString() &&
                    combo_is_purchaseable.Text == row.Cells["sub_unit_is_purchaseable"].Value.ToString()
                    )
                {
                    MessageBox.Show("هذه البيانات موجودة بالفعل و سيتم تجاهلها و لا يوجد اي تعديلات");
                    return;
                }

                else if (
                    combo_base_units.SelectedValue.ToString() != row.Cells["base_unit_id"].Value.ToString() &&
                    combo_sub_units.SelectedValue.ToString() != row.Cells["sub_unit_id"].Value.ToString() &&
                    text_contents_amount.Text != row.Cells["sub_unit_count"].Value.ToString() &&
                    combo_is_purchaseable.Text != row.Cells["sub_unit_is_purchaseable"].Value.ToString()
                    )
                {
                    // Add new information
                }

                List<string> old_data = new List<string>();
                old_data.Add(row.Cells["base_unit_name"].Value.ToString());
                old_data.Add(row.Cells["sub_unit_name"].Value.ToString());
                old_data.Add(row.Cells["sub_unit_count"].Value.ToString());
                old_data.Add(row.Cells["sub_unit_is_purchaseable"].Value.ToString());

                List<string> new_data = new List<string>();
                new_data.Add(combo_base_units.Text);
                new_data.Add(combo_sub_units.Text);
                new_data.Add(text_contents_amount.Text);
                new_data.Add(combo_is_purchaseable.Text);


                FormExistedDataMessage msg = new FormExistedDataMessage();
                MessageResult result = msg.Confirm(old_data, new_data);

                if (result == MessageResult.SAVE_NEW)
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                else if (result == MessageResult.MODIFY_EXISTED)
                {
                    MessageBox.Show("تم التعديل بنجاح");
                }

                else if (result == MessageResult.IGNORE)
                {
                    MessageBox.Show("تم الاغاء");
                }
            }
        }

        void CalcProfitMargin()
        {
            double purcahsing;
            double selling;
            if (!double.TryParse(text_purchasing_price.Text, out purcahsing))
            {
                text_purchasing_price.Text = "0.0";
                text_purchasing_price.SelectAll();
                return;
            }

            if ( !double.TryParse(text_selling_price.Text, out selling))
            {
                text_selling_price.Text = "0.0";
                text_selling_price.SelectAll();
                return;
            }
            text_profit_margin.Text = (selling - purcahsing).ToString();
        }
        private void Text_purchasing_price_TextChanged(object sender, EventArgs e)
        {
            CalcProfitMargin();
        }

        private void Text_selling_price_TextChanged(object sender, EventArgs e)
        {
            CalcProfitMargin();
        }
    }
}
