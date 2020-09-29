using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserControls
{

    public partial class FormAllCategoryProducts : Form
    {
        private DataAccessLayer.DBHandler db = new DataAccessLayer.DBHandler();
        public FormAllCategoryProducts()
        {
            InitializeComponent();
        }

        public void AShowDialog()
        {
            combo_category.DisplayMember = "category";
            combo_category.ValueMember = "id";
            combo_category.DataSource = DataAccessLayer.DBHelber.Categories();

            combo_category.SelectedValueChanged += combo_category_SelectedValueChanged;
            combo_category_SelectedValueChanged(combo_category, EventArgs.Empty);


            dgv_all_products.DoubleBuffered(true);
            dgv_bill.DoubleBuffered(true);

            this.ShowDialog();
        }

        private void dgv_all_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct(e.RowIndex);
        }

        private void dgv_all_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct(e.RowIndex);

            SelectProduct(dgv_all_products.CurrentRow.Index);
            dgv_bill.Rows.Add(
                false,
              dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
              dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
              dgv_all_products.CurrentRow.Cells["product_name"].Value.ToString(),
              dgv_all_products.CurrentRow.Cells["unit_name"].Value.ToString(),
              dgv_all_products.CurrentRow.Cells["selling_price"].Value.ToString(),
              "0",
              "0",
              dgv_all_products.CurrentRow.Cells["clmn_category_id"].Value.ToString(),
              dgv_all_products.CurrentRow.Cells["unit_id"].Value.ToString());
        }

        private void SelectProduct(int row_index)
        {
            if (row_index >= 0)
            {
                SelectedProductChangedArgs selected_product_name = new SelectedProductChangedArgs()
                {
                    ProductName = dgv_all_products.Rows[row_index].Cells["product_id"].Value.ToString(),
                    CategoryName = dgv_all_products.Rows[row_index].Cells["clmn_category_name"].Value.ToString()
                };
                OnProductSelected(selected_product_name);
            }
        }
        private void combo_category_SelectedValueChanged(object sender, EventArgs e)
        {
            string sql = string.Format(@"
SELECT  products.category_id AS category_id,
        categories.category AS category_name,
        products.product_id,
        products_names.product_name,
        units.unit AS unit_name,
        units.id AS unit_id,
        products.selling_price,
        products.amount

FROM products
JOIN categories ON products.category_id = categories.id
JOIN units ON products.unit_id = units.id
JOIN products_names ON products.product_name_id = products_names.product_name_id 
WHERE categories.id = {0}
ORDER BY products_names.product_name;", combo_category.SelectedValue.ToString());

            dgv_all_products.DataSource = db.ExecuteSQL(sql);
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            string search_query = string.Format(@"
SELECT  products.category_id AS category_id,
        categories.category AS category_name,
        products.product_id,
        products_names.product_name,
        units.unit AS unit_name,
        units.id AS unit_id,
        products.selling_price,
        products.amount

FROM products
JOIN categories ON products.category_id = categories.id
JOIN units ON products.unit_id = units.id
JOIN products_names ON products.product_name_id = products_names.product_name_id 
WHERE products_names.product_name LIKE '%{0}%'
ORDER BY category_id, products_names.product_name, products.selling_price


", text_search.Text.Trim());
            dgv_all_products.DataSource = db.ExecuteSQL(search_query);

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
                SelectProduct(dgv_all_products.CurrentRow.Index);
                dgv_bill.Rows.Add(
                    false,
                  dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
                  dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
                  dgv_all_products.CurrentRow.Cells["product_name"].Value.ToString(),
                  dgv_all_products.CurrentRow.Cells["unit_name"].Value.ToString(),
                  dgv_all_products.CurrentRow.Cells["selling_price"].Value.ToString(),
                  "0",
                  "0",
                  dgv_all_products.CurrentRow.Cells["clmn_category_id"].Value.ToString(),
                  dgv_all_products.CurrentRow.Cells["unit_id"].Value.ToString());
                text_amount.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F1)
            {
                text_search.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                text_amount.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dgv_bill.Rows.Add(
                    false,
                   dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
                   dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
                   dgv_all_products.CurrentRow.Cells["product_name"].Value.ToString(),
                   dgv_all_products.CurrentRow.Cells["unit_name"].Value.ToString(),
                   dgv_all_products.CurrentRow.Cells["selling_price"].Value.ToString(),
                   "0",
                   "0",
                   dgv_all_products.CurrentRow.Cells["clmn_category_id"].Value.ToString(),
                   dgv_all_products.CurrentRow.Cells["unit_id"].Value.ToString());
            }
        }

        private void text_search_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                dgv_all_products.Focus();
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
                ProductName = dgv_all_products.CurrentRow.Cells["product_id"].Value.ToString(),
                CategoryName = dgv_all_products.CurrentRow.Cells["clmn_category_name"].Value.ToString(),
                Amount = text_amount.Text
            };
            OnProductSaved(selected_product);
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
            if (dgv_bill.Rows.Count == 0) return;
            dgv_bill.ClearSelection();
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_save.PerformClick();
                dgv_bill.Rows[dgv_bill.Rows.Count - 1].Cells["dgvBillAmountColumn"].Value = text_amount.Text;
                text_amount.Text = "";
                text_search.Focus();
                text_search.SelectAll();
            }
        }

        private void pnl_bell_MouseHover(object sender, EventArgs e)
        {

        }

        private void dgv_bill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.ColumnIndex == 6 && dgv_bill.Rows.Count > 0)
            {
                double old_total;
                double.TryParse(dgv_bill.Rows[e.RowIndex].Cells[7].Value.ToString(), out old_total);
                lbl_total.Text = (double.Parse(lbl_total.Text) - old_total).ToString();
                double amount, price;
                double.TryParse(dgv_bill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out amount);
                double.TryParse(dgv_bill.Rows[e.RowIndex].Cells[5].Value.ToString(), out price);

                dgv_bill.Rows[e.RowIndex].Cells[7].Value = amount * price;
                lbl_total.Text = (double.Parse(lbl_total.Text) + (amount * price)).ToString();
            }
        }

        private void text_paid_TextChanged(object sender, EventArgs e)
        {
            double total, paid, change;
            double.TryParse(lbl_total.Text, out total);
            if (!double.TryParse(text_paid.Text, out paid))
            {
                text_paid.Text = "0.0";
                text_paid.SelectAll();
            }
            change = paid - total;
            lbl_change.Text = change.ToString();
            double.TryParse(lbl_total.Text, out total);
        }

        private void lbl_total_TextChanged(object sender, EventArgs e)
        {
            text_paid_TextChanged(sender, EventArgs.Empty);
        }

        private void lbl_change_TextChanged(object sender, EventArgs e)
        {
            double change;
            double.TryParse(lbl_change.Text, out change);
            if (change < 0.0)
                lbl_change.ForeColor = Color.Red;
            else lbl_change.ForeColor = Color.Black;
        }

        private void text_amount_TextChanged(object sender, EventArgs e)
        {
            double amount;
            //if (text_amount.Text != ".")
            {
                if (text_amount.Text != "."&&!double.TryParse(text_amount.Text, out amount))
                {
                    text_amount.Text = "0.0";
                    text_amount.SelectAll();
                }
            }
        }

        private void FormAllCategoryProducts_Load(object sender, EventArgs e)
        {
            ActiveControl = text_search;
        }



    }


    public class SelectedProductChangedArgs : EventArgs
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Amount { get; set; }
    }
}
