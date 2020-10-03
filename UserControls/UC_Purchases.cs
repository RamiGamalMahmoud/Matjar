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
        private ProductsRepo productsRepo;
        public UC_Purchases()
        {
            this.InitializeComponent();
            this.combo_category_name.DisplayMember = "category";
            this.combo_category_name.ValueMember = "id";

            this.combo_product_name.DisplayMember = "product_name";
            this.combo_product_name.ValueMember = "product_name_id";
        }

        public void Start()
        {
            if (this.repo == null)
            {
                this.repo = new PurchasesRepo();
                this.productsRepo = new ProductsRepo();
                this.dgv_purchases.DoubleBuffered(true);
                using (CategoriesRepo categoriesRepo = new CategoriesRepo())
                {
                    this.combo_category_name.DataSource = categoriesRepo.GetCategories();
                }
                this.combo_category_name.SelectedIndexChanged += this.combo_category_name_SelectedIndexChanged;
                this.combo_category_name_SelectedIndexChanged(this.combo_category_name, EventArgs.Empty);
                this.combo_unit_name.SelectedIndexChanged += this.combo_unit_name_SelectedIndexChanged;
                this.combo_years.DataSource = this.repo.GetYears().ColumnToArray(0);
            }
        }

        private void combo_category_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_category_id.Text = this.combo_category_name.SelectedValue.ToString();
            this.combo_product_name.DataSource = this.productsRepo.GetCategoryProducts(this.combo_category_name.SelectedValue.ToString());
        }

        private void combo_product_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_product_name_id.Text = this.combo_product_name.SelectedValue.ToString();
            this.GetUintsForProducts();
        }

        private void GetUintsForProducts()
        {
            this.combo_unit_name.DisplayMember = "unit_name";
            this.combo_unit_name.ValueMember = "unit_id";
            this.combo_unit_name.DataSource = this.repo.GetProductUnitsInfo(this.combo_product_name.SelectedValue.ToString());
        }

        private void combo_unit_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbl_unit_id.Text = this.combo_unit_name.SelectedValue.ToString();
        }

        private void calcTotal(object sender, EventArgs e)
        {
            double price, quantity;
            double.TryParse(this.text_price.Text, out price);
            double.TryParse(this.text_quantity.Text, out quantity);

            this.lbl_total.Text = (price * quantity).ToString();
        }



        private void btn_save_Click(object sender, EventArgs e)
        {

            if (this.lbl_total.Text == "0")
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
                this.combo_product_name.SelectedValue.ToString(),
                this.combo_unit_name.SelectedValue.ToString(),
                this.text_price.Text);
            DateTime date = this.dateTimePicker1.Value;

            List<string> purchasedProduct = new List<string>();
            purchasedProduct.Add(this.combo_category_name.SelectedValue.ToString());
            purchasedProduct.Add(this.combo_product_name.SelectedValue.ToString());
            purchasedProduct.Add(this.combo_unit_name.SelectedValue.ToString());
            purchasedProduct.Add(this.text_price.Text);
            purchasedProduct.Add(this.text_quantity.Text);
            purchasedProduct.Add(this.lbl_total.Text);
            purchasedProduct.Add(date.ToString("yyyy/MM/dd"));

            this.repo.SavePurchasedProduct(purchasedProduct);

            this.repo.UpdateMonthes(date.Date.ToString("yyyy"), date.Date.ToString("MM"));

            this.combo_years_SelectedIndexChanged(this.combo_years, EventArgs.Empty);
        }

        private void combo_years_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.combo_monthes.DataSource = this.repo.GetMonthesOfYear(this.combo_years.Text).ColumnToArray(0);
        }

        private void combo_monthes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgv_purchases.DataSource = this.repo.GetPurchases(this.combo_years.Text, this.combo_monthes.Text);
        }

        private void dgv_purchases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.combo_category_name.Text = this.dgv_purchases.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.combo_product_name.Text = this.dgv_purchases.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.combo_unit_name.Text = this.dgv_purchases.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.text_price.Text = this.dgv_purchases.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.text_quantity.Text = this.dgv_purchases.Rows[e.RowIndex].Cells[4].Value.ToString();

            SettingPrices setting_prices = new SettingPrices();
            setting_prices.ShowDialog(this.lbl_product_name_id.Text, this.lbl_unit_id.Text, this.text_price.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string year = this.dateTimePicker1.Value.ToString("yyyy");
            string month = this.dateTimePicker1.Value.ToString("MM");
            if (this.combo_years.Items.Contains(year))
            {
                if (this.combo_monthes.Items.Contains(month))
                {
                    this.combo_years.Text = year;
                    this.combo_monthes.Text = month;
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
            this.TextBoxSelectAll(sender);
        }

        private void text_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            this.TextBoxSelectAll(sender);
        }

        private void lbl_product_name_id_Click(object sender, EventArgs e)
        {
            this.GetUintsForProducts();
        }
    }
}
