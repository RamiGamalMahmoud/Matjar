using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Repos;


namespace UserControls
{
    public partial class UC_Sales : UserControl
    {
        private SalesRepo repo;
        public int LastSerial { get; set; }
        public string WorkDay { get; set; }
        public string NextProcessId { get; set; }

        private Models.Product CurrentProduct = new Models.Product();
        private Timer timer = new Timer();


        public UC_Sales()
        {
            this.InitializeComponent();
            foreach (DataGridViewColumn col in this.dgv_sales.Columns)
            {
                col.ContextMenuStrip = this.dgvDailySalesProperties;
            }

            this.combo_category_name.DisplayMember = "category";
            this.combo_category_name.ValueMember = "id";
            this.combo_product_name.DisplayMember = "product_name";
            this.combo_product_name.ValueMember = "product_id";
        }

        private void UC_DailySales_Load(object sender, EventArgs e)
        {

        }
        public void Start()
        {
            this.dgv_sales.DoubleBuffered(true);
            this.repo = new SalesRepo();

            this.lbl_work_day.Text = this.date_picker_work_day.Value.ToString("ddd") + " " + this.date_picker_work_day.Value.ToString("yyyy/M/d");
            this.WorkDay = this.date_picker_work_day.Value.ToString("yyyyMMdd");
            this.lbl_day_total.Text = "0";
            this.timer.Interval = 10;
            this.timer.Tick += this.timer_Tick;
            this.timer.Start();

            this.date_picker_work_day.Value = DateTime.Now.Date;

            this.viewWorkDaySales();
            this.dgv_sales.CellValueChanged += this.dgv_sales_CellValueChanged;

            this.combo_category_name.DataSource = this.repo.GetCategories();

            this.combo_category_name.SelectedValueChanged += this.combo_category_name_SelectedValueChanged;
            this.combo_category_name_SelectedValueChanged(this.combo_category_name, EventArgs.Empty);
            this.combo_product_name.SelectedValueChanged += this.combo_product_name_SelectedValueChanged;
            this.combo_product_name_SelectedValueChanged(this.combo_product_name, EventArgs.Empty);
        }


        private void combo_category_name_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lbl_category_id.Text = this.combo_category_name.SelectedValue.ToString();
            this.combo_product_name.DataSource = this.repo.GetCategoryProducts(this.combo_category_name.SelectedValue.ToString());

        }


        private void combo_product_name_SelectedValueChanged(object sender, EventArgs e)
        {

            if (this.combo_product_name.SelectedValue != null)
            {
                this.lbl_product_id.Text = this.combo_product_name.SelectedValue.ToString();
                this.CurrentProduct.ProductID = int.Parse(this.combo_product_name.SelectedValue.ToString());
                this.lbl_price.Text = this.CurrentProduct.selling_price.ToString();
                this.lbl_unit.Text = this.CurrentProduct.unit_name.ToString();

                this.upateTotal();
                this.text_quantity.Focus();
                this.text_quantity.SelectAll();
            }
        }

        private void viewWorkDaySales()
        {
            this.dgv_sales.DataSource = this.repo.GetDaySales(this.WorkDay);
            this.NextProcessId = this.generateProcessID((DataTable)this.dgv_sales.DataSource);
        }
        private string generateProcessID(DataTable t)
        {
            string last_process_id;
            if (t.Rows.Count == 0)
            {
                this.LastSerial = 1;
                return this.WorkDay + "000" + this.LastSerial.ToString();
            }
            else
            {
                last_process_id = t.Rows[t.Rows.Count - 1][0].ToString();
                this.LastSerial = int.Parse(last_process_id.Substring(8));
                double day_total = 0;

                foreach (DataRow dr in t.Rows)
                {
                    day_total += double.Parse(dr["total"].ToString());
                }
                this.dgv_sales.DataSource = t;
                this.lbl_day_total.Text = day_total.ToString();
                this.LastSerial++;
                return this.WorkDay.PadRight(12 - this.LastSerial.ToString().Length, '0') + (this.LastSerial).ToString();

            }
        }

        private void updateNextProcessID()
        {
            this.LastSerial++;
            this.NextProcessId = this.WorkDay.PadRight(12 - this.LastSerial.ToString().Length, '0') + (this.LastSerial).ToString();
        }

        private void upateTotal()
        {
            double price = 0, quantity = 0;
            double.TryParse(this.lbl_price.Text, out price);
            double.TryParse(this.text_quantity.Text, out quantity);
            this.lbl_total.Text = (price * quantity).ToString();
        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {
            double quantity;
            if (!double.TryParse(this.text_quantity.Text, out quantity) && !this.text_quantity.Text.Contains('.'))
            {
                this.text_quantity.Text = "0.0";
                this.text_quantity.SelectAll();
            }
            this.upateTotal();
        }

        private void text_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            this.text_quantity.SelectAll();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            double x;
            if (this.text_quantity.Text == "0" || !double.TryParse(this.text_quantity.Text, out x))
                return;
            List<string> data = new List<string>();


            data.Add(this.NextProcessId);
            data.Add(this.CurrentProduct.ProductID.ToString());

            data.Add(this.text_quantity.Text);
            data.Add(this.CurrentProduct.selling_price.ToString());

            data.Add(this.lbl_total.Text);
            data.Add(DateTime.Now.ToString("HH:mm:ss"));
            data.Add(DateTime.Now.Date.ToShortDateString());
            data.Add(this.CurrentProduct.category_id.ToString());

            data.Add(this.CurrentProduct.unit_id.ToString());

            this.repo.CreateSales(data);

            //DataTable sales_data_table = (DataTable)dgv_sales.DataSource;
            ((DataTable)this.dgv_sales.DataSource).Rows.Add(this.repo.GetSalesOfProcess(this.NextProcessId).ItemArray);
            this.text_quantity.Text = "0";
            this.text_quantity.Focus();
            this.text_quantity.SelectAll();
            this.updateNextProcessID();

            double day_total = double.Parse(this.lbl_day_total.Text.ToString());
            day_total += double.Parse(this.dgv_sales.Rows[this.dgv_sales.Rows.Count - 1].Cells[7].Value.ToString());
            this.lbl_day_total.Text = day_total.ToString();
            this.dgv_sales.FirstDisplayedScrollingRowIndex = this.dgv_sales.Rows.Count - 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void text_quantity_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.text_quantity.SelectAll();
        }

        private void text_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_save.PerformClick();
            }
        }


        private int current_row_index;

        private void dgv_sales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.current_row_index = e.RowIndex;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = this.dgv_sales.SelectedRows;
            if (selected.Count > 0)
            {
                for (int i = 0; i < selected.Count; i++)
                {
                    this.repo.RemoveSales(selected[i].Cells[0].Value.ToString());
                    this.dgv_sales.Rows.Remove(selected[i]);
                }
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.dgv_sales.ClearSelection();
                this.dgv_sales.Rows[this.current_row_index].Selected = true;

                this.repo.RemoveSales(this.dgv_sales.Rows[this.current_row_index].Cells[0].Value.ToString());
                this.dgv_sales.Rows.RemoveAt(this.current_row_index);
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (this.dgv_sales.Rows.Count == 0)
            {
                this.LastSerial = 0;
            }
        }

        private void text_quantity_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        public void dgv_sales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                double day_total = double.Parse(this.lbl_day_total.Text);
                day_total = day_total - double.Parse(this.dgv_sales.Rows[e.RowIndex].Cells[7].Value.ToString());
                this.lbl_day_total.Text = day_total.ToString();
                double amount, price, total;
                string process_id;
                amount = double.Parse(this.dgv_sales.Rows[e.RowIndex].Cells[5].Value.ToString());
                price = double.Parse(this.dgv_sales.Rows[e.RowIndex].Cells[6].Value.ToString());
                total = amount * price;
                process_id = this.dgv_sales.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.repo.UpdateSales(process_id, price, amount, total);
                this.dgv_sales.Rows[e.RowIndex].Cells[7].Value = total;
                day_total += total;
                this.lbl_day_total.Text = day_total.ToString();
            }

        }

        private void workDay_ValueChanged(object sender, EventArgs e)
        {
            this.lbl_work_day.Text = this.date_picker_work_day.Value.ToString("ddd") + " " + this.date_picker_work_day.Value.ToString("yyyy/M/d");
            this.WorkDay = this.date_picker_work_day.Value.ToString("yyyyMMdd");
            this.viewWorkDaySales();
        }

        private void gbtn_view_products_Click(object sender, EventArgs e)
        {
            FormAllCategoryProducts all = new FormAllCategoryProducts();
            all.SelectedProductChanged += this.all_SelectedProductChanged;

            all.ProductSaved += this.all_ProductSaved;

            all.AShowDialog();
        }

        private void all_ProductSaved(object sender, SelectedProductChangedArgs e)
        {
            this.combo_category_name.Text = e.CategoryName;
            this.combo_product_name.SelectedValue = e.ProductName;
            this.text_quantity.Text = e.Amount;
            this.btn_save.PerformClick();
        }

        private void all_SelectedProductChanged(object sender, SelectedProductChangedArgs e)
        {
            this.combo_category_name.Text = e.CategoryName;
            this.combo_product_name.SelectedValue = e.ProductName;
        }

    }
}
