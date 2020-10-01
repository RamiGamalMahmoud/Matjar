using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DataAccessLayer;
using Repos;

namespace UserControls
{
    public partial class UC_Purchases : UserControl
    {
        private PurchasesRepo repo;
        public UC_Purchases()
        {
            InitializeComponent();
            combo_category_name.DisplayMember = "category";
            combo_category_name.ValueMember = "id";

            combo_product_name.DisplayMember = "product_name";
            combo_product_name.ValueMember = "product_name_id";
        }

        public void Start()
        {
            if (this.repo == null)
            {
                this.repo = new PurchasesRepo();
                dgv_purchases.DoubleBuffered(true);
                combo_category_name.DataSource = this.repo.GetAllCategories();
                combo_category_name.SelectedIndexChanged += combo_category_name_SelectedIndexChanged;
                combo_category_name_SelectedIndexChanged(combo_category_name, EventArgs.Empty);
                combo_unit_name.SelectedIndexChanged += combo_unit_name_SelectedIndexChanged;
                this.combo_years.DataSource = this.repo.GetYears().ColumnToArray(0);
            }
        }

        private void combo_category_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_category_id.Text = combo_category_name.SelectedValue.ToString();
            this.combo_product_name.DataSource = this.repo.GetCategoryProducts(combo_category_name.SelectedValue.ToString());
        }

        private void combo_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_product_name_id.Text = combo_product_name.SelectedValue.ToString();
            this.GetUintsForProducts();
        }

        private void GetUintsForProducts()
        {
            this.combo_unit_name.DisplayMember = "unit_name";
            this.combo_unit_name.ValueMember = "unit_id";
            this.combo_unit_name.DataSource = this.repo.GetProductUnitsInfo(combo_product_name.SelectedValue.ToString());
        }

        private void combo_unit_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_unit_id.Text = combo_unit_name.SelectedValue.ToString();
        }

        private void calcTotal(object sender, EventArgs e)
        {
            double price, quantity;
            double.TryParse(text_price.Text, out price);
            double.TryParse(text_quantity.Text, out quantity);

            lbl_total.Text = (price * quantity).ToString();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {

            if (lbl_total.Text == "0")
            {
                var notification = new System.Windows.Forms.NotifyIcon()
                {
                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Shield,
                    BalloonTipTitle = "خطأ أثناء الحفظ",
                    BalloonTipText = "الكمية أو السعر فارغ",
                };
                notification.ShowBalloonTip(1000);
                return;
            }

            this.combo_years.DataSource = this.repo.GetYears().ColumnToArray(0);

            new SettingPrices().ShowDialog(
                combo_product_name.SelectedValue.ToString(),
                combo_unit_name.SelectedValue.ToString(),
                text_price.Text);
            DateTime date = dateTimePicker1.Value;

            List<string> purchasedProduct = new List<string>();
            purchasedProduct.Add(combo_category_name.SelectedValue.ToString());
            purchasedProduct.Add(combo_product_name.SelectedValue.ToString());
            purchasedProduct.Add(combo_unit_name.SelectedValue.ToString());
            purchasedProduct.Add(text_price.Text);
            purchasedProduct.Add(text_quantity.Text);
            purchasedProduct.Add(lbl_total.Text);
            purchasedProduct.Add(date.ToString("yyyy/MM/dd"));

            this.repo.SavePurchasedProduct(purchasedProduct);

            this.repo.UpdateMonthes(date.Date.ToString("yyyy"), date.Date.ToString("MM"));

            combo_years_SelectedIndexChanged(combo_years, EventArgs.Empty);
        }

        private void combo_years_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_monthes.DataSource = this.repo.GetMonthesOfYear(combo_years.Text).ColumnToArray(0);
        }

        private void combo_monthes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_purchases.DataSource = this.repo.GetPurchases(combo_years.Text, combo_monthes.Text);
        }

        private void dgv_purchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            combo_category_name.Text = dgv_purchases.Rows[e.RowIndex].Cells[0].Value.ToString();
            combo_product_name.Text = dgv_purchases.Rows[e.RowIndex].Cells[1].Value.ToString();
            combo_unit_name.Text = dgv_purchases.Rows[e.RowIndex].Cells[2].Value.ToString();

            text_price.Text = dgv_purchases.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_quantity.Text = dgv_purchases.Rows[e.RowIndex].Cells[4].Value.ToString();

            SettingPrices setting_prices = new SettingPrices();
            setting_prices.ShowDialog(lbl_product_name_id.Text, lbl_unit_id.Text, text_price.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.ToString("yyyy");
            string month = dateTimePicker1.Value.ToString("MM");
            if (combo_years.Items.Contains(year))
            {
                if (combo_monthes.Items.Contains(month))
                {
                    combo_years.Text = year;
                    combo_monthes.Text = month;
                }
            }
        }

        private void TextBoxSelectAll(object sender)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
        }

        private void text_quantity_Enter(object sender, EventArgs e)
        {
            TextBoxSelectAll(sender);
        }

        private void text_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSelectAll(sender);
        }

        private void lbl_product_name_id_Click(object sender, EventArgs e)
        {
            GetUintsForProducts();
        }
    }
}
