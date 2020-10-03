using System;
using System.Drawing;
using System.Windows.Forms;
using Repos;

namespace UserControls
{

    public partial class FormAllCategoryProducts : Form
    {
        private ProductsRepo productsRepo;
        private CategoriesRepo categoriesRepo;
        public FormAllCategoryProducts()
        {
            this.InitializeComponent();
            this.productsRepo = new ProductsRepo();
            this.categoriesRepo = new CategoriesRepo();
        }

        public void AShowDialog()
        {
            this.combo_category.DisplayMember = "category";
            this.combo_category.ValueMember = "id";
            this.combo_category.DataSource = this.categoriesRepo.GetCategories();

            this.combo_category.SelectedValueChanged += this.combo_category_SelectedValueChanged;
            this.combo_category_SelectedValueChanged(this.combo_category, EventArgs.Empty);


            this.dgv_all_products.DoubleBuffered(true);
            this.dgv_bill.DoubleBuffered(true);

            this.ShowDialog();
        }

        private void dgv_all_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectProduct(e.RowIndex);
        }

        private void dgv_all_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectProduct(e.RowIndex);

            this.SelectProduct(this.dgv_all_products.CurrentRow.Index);
            this.dgv_bill.Rows.Add(
                false,
              this.dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
              this.dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
              this.dgv_all_products.CurrentRow.Cells["product_name"].Value.ToString(),
              this.dgv_all_products.CurrentRow.Cells["unit_name"].Value.ToString(),
              this.dgv_all_products.CurrentRow.Cells["selling_price"].Value.ToString(),
              "0",
              "0",
              this.dgv_all_products.CurrentRow.Cells["clmn_category_id"].Value.ToString(),
              this.dgv_all_products.CurrentRow.Cells["unit_id"].Value.ToString());
        }

        private void SelectProduct(int row_index)
        {
            if (row_index >= 0)
            {
                SelectedProductChangedArgs selected_product_name = new SelectedProductChangedArgs()
                {
                    ProductName = this.dgv_all_products.Rows[row_index].Cells["product_id"].Value.ToString(),
                    CategoryName = this.dgv_all_products.Rows[row_index].Cells["clmn_category_name"].Value.ToString()
                };
                this.OnProductSelected(selected_product_name);
            }
        }
        private void combo_category_SelectedValueChanged(object sender, EventArgs e)
        {
            this.dgv_all_products.DataSource = this.productsRepo.GetCategoryProducts(this.combo_category.SelectedValue.ToString());
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            this.dgv_all_products.DataSource = this.productsRepo.GetProductsByName(this.text_search.Text.Trim());
        }


        public event EventHandler<SelectedProductChangedArgs> SelectedProductChanged;
        public void OnProductSelected(SelectedProductChangedArgs e)
        {
            EventHandler<SelectedProductChangedArgs> handler = SelectedProductChanged;
            if (handler != null)
            {
                SelectedProductChanged(this, e);
            }
        }

        private void bth_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_all_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectProduct(this.dgv_all_products.CurrentRow.Index);
                this.dgv_bill.Rows.Add(
                    false,
                  this.dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
                  this.dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
                  this.dgv_all_products.CurrentRow.Cells["product_name"].Value.ToString(),
                  this.dgv_all_products.CurrentRow.Cells["unit_name"].Value.ToString(),
                  this.dgv_all_products.CurrentRow.Cells["selling_price"].Value.ToString(),
                  "0",
                  "0",
                  this.dgv_all_products.CurrentRow.Cells["clmn_category_id"].Value.ToString(),
                  this.dgv_all_products.CurrentRow.Cells["unit_id"].Value.ToString());
                this.text_amount.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                this.text_search.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.text_amount.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                this.dgv_bill.Rows.Add(
                    false,
                   this.dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
                   this.dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
                   this.dgv_all_products.CurrentRow.Cells["product_name"].Value.ToString(),
                   this.dgv_all_products.CurrentRow.Cells["unit_name"].Value.ToString(),
                   this.dgv_all_products.CurrentRow.Cells["selling_price"].Value.ToString(),
                   "0",
                   "0",
                   this.dgv_all_products.CurrentRow.Cells["clmn_category_id"].Value.ToString(),
                   this.dgv_all_products.CurrentRow.Cells["unit_id"].Value.ToString());
            }
        }

        private void text_search_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                this.dgv_all_products.Focus();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                box.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SelectedProductChangedArgs selected_product = new SelectedProductChangedArgs()
            {
                ProductName = this.dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
                CategoryName = this.dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
                Amount = this.text_amount.Text
            };
            this.OnProductSaved(selected_product);
        }

        public event EventHandler<SelectedProductChangedArgs> ProductSaved;
        protected void OnProductSaved(SelectedProductChangedArgs args)
        {
            EventHandler<SelectedProductChangedArgs> handler = ProductSaved;
            if (handler != null)
            {
                ProductSaved(this, args);
            }
        }

        private void text_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.dgv_bill.Rows.Count == 0)
                return;
            this.dgv_bill.ClearSelection();
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.btn_save.PerformClick();
                this.dgv_bill.Rows[this.dgv_bill.Rows.Count - 1].Cells["dgvBillAmountColumn"].Value = this.text_amount.Text;
                this.text_amount.Text = "";
                this.text_search.Focus();
                this.text_search.SelectAll();
            }
        }

        private void pnl_bell_MouseHover(object sender, EventArgs e)
        {

        }

        private void dgv_bill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && this.dgv_bill.Rows.Count > 0)
            {
                double old_total;
                double.TryParse(this.dgv_bill.Rows[e.RowIndex].Cells[7].Value.ToString(), out old_total);
                this.lbl_total.Text = (double.Parse(this.lbl_total.Text) - old_total).ToString();
                double amount, price;
                double.TryParse(this.dgv_bill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out amount);
                double.TryParse(this.dgv_bill.Rows[e.RowIndex].Cells[5].Value.ToString(), out price);

                this.dgv_bill.Rows[e.RowIndex].Cells[7].Value = amount * price;
                this.lbl_total.Text = (double.Parse(this.lbl_total.Text) + (amount * price)).ToString();
            }
        }

        private void text_paid_TextChanged(object sender, EventArgs e)
        {
            double total, paid, change;
            double.TryParse(this.lbl_total.Text, out total);
            if (!double.TryParse(this.text_paid.Text, out paid))
            {
                this.text_paid.Text = "0.0";
                this.text_paid.SelectAll();
            }
            change = paid - total;
            this.lbl_change.Text = change.ToString();
            double.TryParse(this.lbl_total.Text, out total);
        }

        private void lbl_total_TextChanged(object sender, EventArgs e)
        {
            this.text_paid_TextChanged(sender, EventArgs.Empty);
        }

        private void lbl_change_TextChanged(object sender, EventArgs e)
        {
            double change;
            double.TryParse(this.lbl_change.Text, out change);
            if (change < 0.0)
                this.lbl_change.ForeColor = Color.Red;
            else
                this.lbl_change.ForeColor = Color.Black;
        }

        private void text_amount_TextChanged(object sender, EventArgs e)
        {
            double amount;
            //if (text_amount.Text != ".")
            {
                if (this.text_amount.Text != "." && !double.TryParse(this.text_amount.Text, out amount))
                {
                    this.text_amount.Text = "0.0";
                    this.text_amount.SelectAll();
                }
            }
        }

        private void FormAllCategoryProducts_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.text_search;
        }



    }


    public class SelectedProductChangedArgs : EventArgs
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Amount { get; set; }
    }
}
