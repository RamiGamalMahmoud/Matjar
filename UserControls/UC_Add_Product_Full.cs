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
            this.InitializeComponent();
            this.repo = new ProductsManagementRepo();
        }

        public void Start(DataTable categories, DataTable units)
        {
            this.combo_categories.DisplayMember = "category";
            this.combo_categories.ValueMember = "id";
            this.combo_categories.DataSource = categories;

            this.combo_units.DisplayMember = "unit";
            this.combo_units.ValueMember = "id";
            this.combo_units.DataSource = units;

            this.combo_base_units.BindingContext = new BindingContext();
            this.combo_base_units.DisplayMember = "unit";
            this.combo_base_units.ValueMember = "id";
            this.combo_base_units.DataSource = units;

            this.combo_sub_units.DisplayMember = "unit";
            this.combo_sub_units.ValueMember = "id";
            this.combo_sub_units.DataSource = units;
            this.combo_sub_units.BindingContext = new BindingContext();

            this.combo_categories.SelectedValueChanged += this.combo_categories_SelectedValueChanged;
            this.combo_categories_SelectedValueChanged(this.combo_categories, EventArgs.Empty);

            this.combo_existed_products_names.SelectedValueChanged += this.combo_existed_products_names_SelectedValueChanged;
            this.combo_existed_products_names_SelectedValueChanged(this.combo_categories, EventArgs.Empty);
        }

        private void combo_categories_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable existedProducts = this.repo.GetCategoryProducts(combo_categories.SelectedValue.ToString());

            this.combo_existed_products_names.DisplayMember = "product_name";
            this.combo_existed_products_names.ValueMember = "product_name_id";
            this.combo_existed_products_names.DataSource = existedProducts;
        }

        private void combo_existed_products_names_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.combo_existed_products_names.SelectedValue == null) return;
            string productNameId = this.combo_existed_products_names.SelectedValue.ToString();
            this.dgv_existing_products.DataSource = this.repo.GetProductNameData(productNameId);
            this.dgv_info.DataSource = this.repo.GetUnitsInfo(productNameId);
        }

        private void dgv_info_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SpredInfo(e.RowIndex);
        }


        private void SpredInfo(int row_index)
        {
            this.lbl_info_id.Text = this.dgv_info.Rows[row_index].Cells[0].Value.ToString();
            this.combo_base_units.Text = this.dgv_info.Rows[row_index].Cells[1].Value.ToString();
            this.combo_sub_units.Text = this.dgv_info.Rows[row_index].Cells[3].Value.ToString();
            this.text_contents_amount.Text = this.dgv_info.Rows[row_index].Cells[5].Value.ToString();
            this.combo_is_purchaseable.Text = this.dgv_info.Rows[row_index].Cells[6].Value.ToString();
        }

        private bool IsNameExisted()
        {
            return this.combo_existed_products_names.FindStringExact(this.text_new_product_name.Text) >= 0;
        }

        private void UpdateProductData(Product existed_product)
        {
            List<string> new_data = new List<string>();

            new_data.Add(this.combo_units.Text);
            new_data.Add(this.text_amount.Text);
            new_data.Add(this.text_purchasing_price.Text);
            new_data.Add(this.text_selling_price.Text);
            new_data.Add(this.text_profit_margin.Text);

            if (new FormExistedDataMessage().ShowDialog(this.combo_categories.Text, existed_product, new_data) == DialogResult.OK)
            {
                List<string> data = new List<string>();
                data.Add(this.combo_units.SelectedValue.ToString());
                data.Add(this.text_amount.Text);
                data.Add(this.text_purchasing_price.Text);
                data.Add(this.text_selling_price.Text);
                data.Add(this.text_profit_margin.Text);

                this.repo.UpdateProduct(data, existed_product.ProductID.ToString());
            }
        }

        private void InsertNewProduct()
        {
            List<string> new_data = new List<string>();
            new_data.Add(this.combo_existed_products_names.Text);
            new_data.Add(this.combo_units.Text);
            new_data.Add(this.text_amount.Text);
            new_data.Add(this.text_purchasing_price.Text);
            new_data.Add(this.text_selling_price.Text);
            new_data.Add(this.text_profit_margin.Text);

            if (new FormExistedDataMessage().ShowDialog(this.combo_categories.Text, new_data) == DialogResult.OK)
            {

                List<string> data = new List<string>();
                data.Add(this.text_amount.Text);
                data.Add(this.text_selling_price.Text);
                data.Add(this.text_purchasing_price.Text);
                data.Add(this.text_purchasing_price.Text);
                data.Add(this.combo_existed_products_names.SelectedValue.ToString());
                data.Add(this.combo_categories.SelectedValue.ToString());
                data.Add(this.combo_units.SelectedValue.ToString());
                this.repo.CreateNewProduct(data);
            }
        }
        private void UpdateProductsNames()
        {
            this.repo.CreateProductName(this.text_new_product_name.Text, this.combo_categories.SelectedValue.ToString());
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
            this.btn_add_new_product_name.Visible = false;
            this.text_new_product_name.Visible = true;
            this.lbl_add_new_product_name.Visible = true;
            this.btn_back.Visible = true;
            this.text_new_product_name.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.btn_add_new_product_name.Visible = true;
            this.text_new_product_name.Visible = false;
            this.lbl_add_new_product_name.Visible = false;
            this.btn_back.Visible = false;
            this.text_new_product_name.Text = "";
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
            if (!double.TryParse(this.text_purchasing_price.Text, out purcahsing))
            {
                this.text_purchasing_price.Text = "0.0";
                this.text_purchasing_price.SelectAll();
                return;
            }

            if (!double.TryParse(this.text_selling_price.Text, out selling))
            {
                this.text_selling_price.Text = "0.0";
                this.text_selling_price.SelectAll();
                return;
            }
            this.text_profit_margin.Text = (selling - purcahsing).ToString();
        }

        private void Text_purchasing_price_TextChanged(object sender, EventArgs e)
        {
            this.CalcProfitMargin();
        }

        private void Text_selling_price_TextChanged(object sender, EventArgs e)
        {
            this.CalcProfitMargin();
        }
    }
}
