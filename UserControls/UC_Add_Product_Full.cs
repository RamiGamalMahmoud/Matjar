using System;
using System.Data;
using System.Windows.Forms;
using GControls;
using System.Collections.Generic;
using Repos;
using Models;

namespace UserControls
{
    public partial class UC_Add_Product_Full : UserControl
    {
        private ProductsManagementRepo repo;

        public UC_Add_Product_Full()
        {
            InitializeComponent();
            this.repo = new ProductsManagementRepo();
        }

        public void Start(DataTable categories, DataTable units)
        {
            combo_categories.DisplayMember = "category";
            combo_categories.ValueMember = "id";
            combo_categories.DataSource = categories;

            combo_units.DisplayMember = "unit";
            combo_units.ValueMember = "id";
            combo_units.DataSource = units;

            combo_base_units.BindingContext = new BindingContext();
            combo_base_units.DisplayMember = "unit";
            combo_base_units.ValueMember = "id";
            combo_base_units.DataSource = units;

            combo_sub_units.DisplayMember = "unit";
            combo_sub_units.ValueMember = "id";
            combo_sub_units.DataSource = units;
            combo_sub_units.BindingContext = new BindingContext();

            combo_categories.SelectedValueChanged += combo_categories_SelectedValueChanged;
            combo_categories_SelectedValueChanged(combo_categories, EventArgs.Empty);

            combo_existed_products_names.SelectedValueChanged += combo_existed_products_names_SelectedValueChanged;
            combo_existed_products_names_SelectedValueChanged(combo_categories, EventArgs.Empty);
        }

        private void combo_categories_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable existedProducts = this.repo.GetCategoryProducts(combo_categories.SelectedValue.ToString());

            combo_existed_products_names.DisplayMember = "product_name";
            combo_existed_products_names.ValueMember = "product_name_id";
            combo_existed_products_names.DataSource = existedProducts;
        }

        private void combo_existed_products_names_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_existed_products_names.SelectedValue == null) return;
            string productNameId = combo_existed_products_names.SelectedValue.ToString();
            dgv_existing_products.DataSource = this.repo.GetProductNameData(productNameId);
            dgv_info.DataSource = this.repo.GetUnitsInfo(productNameId);
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

        private void UpdateProductData(Product existed_product)
        {
            List<string> new_data = new List<string>();

            new_data.Add(combo_units.Text);
            new_data.Add(text_amount.Text);
            new_data.Add(text_purchasing_price.Text);
            new_data.Add(text_selling_price.Text);
            new_data.Add(text_profit_margin.Text);

            if (new FormExistedDataMessage().ShowDialog(combo_categories.Text, existed_product, new_data) == DialogResult.OK)
            {
                List<string> data = new List<string>();
                data.Add(combo_units.SelectedValue.ToString());
                data.Add(text_amount.Text);
                data.Add(text_purchasing_price.Text);
                data.Add(text_selling_price.Text);
                data.Add(text_profit_margin.Text);

                this.repo.UpdateProduct(data, existed_product.ProductID.ToString());
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

                List<string> data = new List<string>();
                data.Add(text_amount.Text);
                data.Add(text_selling_price.Text);
                data.Add(text_purchasing_price.Text);
                data.Add(text_purchasing_price.Text);
                data.Add(combo_existed_products_names.SelectedValue.ToString());
                data.Add(combo_categories.SelectedValue.ToString());
                data.Add(combo_units.SelectedValue.ToString());
                this.repo.CreateNewProduct(data);
            }
        }
        private void UpdateProductsNames()
        {
            this.repo.CreateProductName(text_new_product_name.Text, combo_categories.SelectedValue.ToString());
        }

        public event EventHandler<MessageArgs> SendMessage;
        protected void OnSendMessage(MessageArgs e)
        {
            SendMessage?.Invoke(this, e);
            //EventHandler<MessageArgs> handler = SendMessage;
            //if (handler != null)
            //    handler(this, e);
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

            if (!double.TryParse(text_selling_price.Text, out selling))
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
