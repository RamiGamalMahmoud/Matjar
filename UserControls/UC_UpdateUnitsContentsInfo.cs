using DataAccessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UserControls
{
    public partial class UC_UpdateUnitsContentsInfo : UserControl
    {
        DBHandler db;
        public UC_UpdateUnitsContentsInfo()
        {
            InitializeComponent();
            dgv_info.AutoGenerateColumns = false;
        }

        public void Start(DataTable categories, DataTable units)
        {
            if (db == null) db = new DBHandler();
            combo_categories.ValueMember = "id";
            combo_categories.DisplayMember = "category";
            combo_categories.BindingContext = new BindingContext();
            combo_categories.DataSource = categories;

            combo_base_units.ValueMember = "id";
            combo_base_units.DisplayMember = "unit";
            combo_base_units.BindingContext = new BindingContext();

            combo_sub_units.ValueMember = "id";
            combo_sub_units.DisplayMember = "unit";
            combo_sub_units.BindingContext = new BindingContext();

            combo_base_units.DataSource = combo_sub_units.DataSource = units;

            combo_categories.SelectedValueChanged += combo_categories_SelectedIndexChanged;
            combo_categories_SelectedIndexChanged(combo_categories, EventArgs.Empty);

            combo_products_names.SelectedIndexChanged += combo_products_names_SelectedIndexChanged;
            combo_products_names_SelectedIndexChanged(combo_products_names, EventArgs.Empty);
        }

        private void combo_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_products_names.ValueMember = "product_name_id";
            combo_products_names.DisplayMember = "product_name";
            combo_products_names.DataSource = DBHelber.GetCategoryProducts(combo_categories.SelectedValue.ToString());
        }

        private void combo_products_names_SelectedIndexChanged(object sender, EventArgs e)
        {

            string units_info_query = "select * from units_info where product_name_id = ";
            units_info_query += combo_products_names.SelectedValue.ToString();
            dgv_info.DataSource = db.ExecuteSQL(units_info_query);
            if (dgv_info.Rows.Count > 0)
                SpredInfo(0);
            else
            {
                lbl_info_id.Text = "";
                text_contents_amount.Text = "0";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            double count;
            double.TryParse(text_contents_amount.Text, out count);
            if (!double.TryParse(text_contents_amount.Text, out count))
            {
                MessageBox.Show("لقد تم كتابة العدد بطريقة خاطئة");
            }
            else if (string.IsNullOrEmpty(text_contents_amount.Text) || text_contents_amount.Text == "0")
            {
                MessageBox.Show("العدد لايمكن ان يكون فارغا او صفر");
                return;
            }

            foreach (DataGridViewRow row in dgv_info.Rows)
            {

                if (row.Cells["base_unit_name"].Value.ToString() == combo_base_units.Text && row.Cells["sub_unit_name"].Value.ToString() == combo_sub_units.Text)
                {
                    dgv_info.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                    row.Selected = true;


                    DialogResult existed_result = MessageBox.Show(
@"!هذه البيانات موجودة بالفعل
هل تريد التعديل ؟", "اضافة",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    dgv_info.ClearSelection();

                    if (existed_result == DialogResult.Cancel) return;

                }
                
            }

            string sql = string.Format(@"INSERT INTO products_units_info SELECT NULL, {0}, {1}, {2}, {3}, '{4}'
                                                    WHERE NOT EXISTS ( SELECT 1 FROM products_units_info 
                                                    WHERE product_name_id = {0} AND 
                                                          base_unit_id = {1} AND
                                                          sub_unit_id = {2} AND
                                                          sub_unit_count = {3} )",
                combo_products_names.SelectedValue.ToString(),
                combo_base_units.SelectedValue.ToString(),
                combo_sub_units.SelectedValue.ToString(),
                text_contents_amount.Text,
                comboBox1.Text);
            DialogResult result = MessageBox.Show(string.Format(@"البيانات التالية سيتم اضافتها

-------------------------------

          اسم الصنف
             {0}

-------------------------------
الوحدة الاساسية :   {1}
-------------------------------
الوحدة الفرعية :   {2}
-------------------------------
عدد الوحداة الفرعية :   {3}",
                            combo_products_names.Text.ToString(),
                            combo_base_units.Text,
                            combo_sub_units.Text,
                            text_contents_amount.Text), "اضافة", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            if (result == DialogResult.OK)
            {
                db.ExecuteNonQuery(sql);
                combo_products_names_SelectedIndexChanged(new object(), EventArgs.Empty);

            }
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
            comboBox1.Text = dgv_info.Rows[row_index].Cells[6].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_info_id.Text))
            {
                return;
            }
            string sql = string.Format(@"
UPDATE products_units_info
   SET base_unit_id = {0} ,
       sub_unit_id = {1} ,
       sub_unit_count = {2} ,
       sub_unit_is_purchaseable = '{3}'
WHERE info_id = {4}"
                ,
                combo_base_units.SelectedValue.ToString(),
                combo_sub_units.SelectedValue.ToString(),
                text_contents_amount.Text,
                comboBox1.Text,
                lbl_info_id.Text
                );
            db.ExecuteSQL(sql);
        }

        private void dgv_info_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dgv_info_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && dgv_info.SelectedRows.Count > 0)
            {
                DialogResult result =  MessageBox.Show("هل تريد حذف هذا البيان ؟","",MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dgv_info.Rows.Remove(dgv_info.SelectedRows[0]);
                    string remove_info = string.Format(@"
DELETE FROM products_units_info WHER info_id = {0}
",lbl_info_id.Text);
                    MessageBox.Show(remove_info);
                    db.deleteData("products_units_info", "info_id", lbl_info_id.Text);
                }
            }
        }
    }
}
