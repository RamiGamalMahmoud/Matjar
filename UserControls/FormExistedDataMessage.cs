using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UserControls
{
    public enum MessageResult { IGNORE, MODIFY_EXISTED, SAVE_NEW }
    public partial class FormExistedDataMessage : Form
    {
        private MessageResult ConflictResult { get; set; }
        private DialogResult Result { get; set; }
        public FormExistedDataMessage()
        {
            this.InitializeComponent();
        }

        public DialogResult ShowDialog(string category, List<string> product_data)
        {
            this.btn_cancel.Visible = true;
            this.btn_ok.Visible = true;
            this.btn_save_new.Visible = false;
            this.btn_modify_existed.Visible = false;
            this.btn_ignore.Visible = false;

            this.lbl_product_name.Text = category + "  ( " + product_data[0] + " )";
            this.lbl_header.ForeColor = Color.DarkOliveGreen;
            this.lbl_header.Text = "البيانات الجديدة التي سيتم ادخالها";

            this.dgv_existing_products.Rows.Add("الوحدة", "", product_data[1]);
            this.dgv_existing_products.Rows.Add("العدد", "", product_data[2]);
            this.dgv_existing_products.Rows.Add("سعر الشراء", "", product_data[3]);
            this.dgv_existing_products.Rows.Add("سعر البيع", "", product_data[4]);
            this.dgv_existing_products.Rows.Add("هامش الربح", "", product_data[5]);

            this.dgv_existing_products.Columns[1].Visible = false;
            this.dgv_existing_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.ShowDialog();
            return this.Result;
        }


        public MessageResult Confirm(List<string> old_data, List<string> new_data)
        {
            this.lbl_header.BackColor = Color.FromArgb(255, 128, 128);
            this.lbl_header.ForeColor = Color.Black;
            this.lbl_header.Text = string.Format(@"بيانات متشابهة اضغط
            حفظ جديد او تعديل او الغاء لتجاهل الامر");
            this.btn_cancel.Visible = false;
            this.btn_ok.Visible = false;
            this.btn_save_new.Visible = true;
            this.btn_modify_existed.Visible = true;
            this.btn_ignore.Visible = true;

            this.dgv_existing_products.Rows.Add("الوحدة الاساسية", old_data[0], new_data[0]);
            this.dgv_existing_products.Rows.Add("الوحدة الفرعية", old_data[1], new_data[1]);
            this.dgv_existing_products.Rows.Add("العدد", old_data[2], new_data[2]);
            this.dgv_existing_products.Rows.Add("الوحدة الفرعية قابلة للشراء", old_data[3], new_data[3]);
            this.ShowDialog();
            return this.ConflictResult;
        }
        public DialogResult ShowDialog(string category, Product existed_product, List<string> new_data)
        {
            this.FillGridView(category, existed_product, new_data);
            this.ShowDialog();
            return this.Result;
        }
        public void FillGridView(string category, Product existed_product, List<string> new_data)
        {
            this.btn_cancel.Visible = true;
            this.btn_ok.Visible = true;
            this.btn_save_new.Visible = false;
            this.btn_modify_existed.Visible = false;
            this.btn_ignore.Visible = false;

            this.lbl_product_name.Text = category + "  ( " + existed_product.product_name + " )";

            this.dgv_existing_products.Rows.Add("الوحدة", existed_product.unit_name, new_data[0]);
            this.dgv_existing_products.Rows.Add("العدد", existed_product.amount, new_data[1]);
            this.dgv_existing_products.Rows.Add("سعر الشراء", existed_product.purchaning_price, new_data[2]);
            this.dgv_existing_products.Rows.Add("سعر البيع", existed_product.selling_price, new_data[3]);
            this.dgv_existing_products.Rows.Add("هامش الربح", existed_product.profit_margin, new_data[4]);
        }

        private void dgv_existing_products_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.OK;
            this.save_or_cancel.Checked = true;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.save_or_cancel.Checked = false;
            this.Close();
        }

        private void btn_save_new_Click(object sender, EventArgs e)
        {
            this.ConflictResult = MessageResult.SAVE_NEW;
            this.Close();
        }

        private void btn_modify_existed_Click(object sender, EventArgs e)
        {
            this.ConflictResult = MessageResult.MODIFY_EXISTED;
            this.Close();
        }

        private void btn_ignore_Click(object sender, EventArgs e)
        {
            this.ConflictResult = MessageResult.IGNORE;
            this.Close();
        }
    }
}
