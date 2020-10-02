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
            InitializeComponent();
            foreach (DataGridViewColumn col in dgv_sales.Columns)
            {
                col.ContextMenuStrip = dgvDailySalesProperties;
            }

            combo_category_name.DisplayMember = "category";
            combo_category_name.ValueMember = "id";

            combo_product_name.DisplayMember = "product_name";
            combo_product_name.ValueMember = "product_id";
        }

        private void UC_DailySales_Load(object sender, EventArgs e)
        {

        }
        public void Start()
        {
            dgv_sales.DoubleBuffered(true);
            this.repo = new SalesRepo();

            lbl_work_day.Text = date_picker_work_day.Value.ToString("ddd") + " " + date_picker_work_day.Value.ToString("yyyy/M/d");
            WorkDay = date_picker_work_day.Value.ToString("yyyyMMdd");
            lbl_day_total.Text = "0";
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            timer.Start();

            date_picker_work_day.Value = DateTime.Now.Date;

            viewWorkDaySales();
            dgv_sales.CellValueChanged += dgv_sales_CellValueChanged;

            combo_category_name.DataSource = DataAccessLayer.DBHelber.Categories();

            combo_category_name.SelectedValueChanged += combo_category_name_SelectedValueChanged;
            combo_category_name_SelectedValueChanged(combo_category_name, EventArgs.Empty);

            combo_product_name.SelectedValueChanged += combo_product_name_SelectedValueChanged;
            combo_product_name_SelectedValueChanged(combo_product_name, EventArgs.Empty);
        }


        private void combo_category_name_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_category_id.Text = combo_category_name.SelectedValue.ToString();
            combo_product_name.DataSource = DataAccessLayer.DBHelber.GetAllProducts(combo_category_name.SelectedValue.ToString());

        }


        private void combo_product_name_SelectedValueChanged(object sender, EventArgs e)
        {

            if (combo_product_name.SelectedValue != null)
            {
                lbl_product_id.Text = combo_product_name.SelectedValue.ToString();
                this.CurrentProduct.ProductID = int.Parse(combo_product_name.SelectedValue.ToString());
                lbl_price.Text = this.CurrentProduct.selling_price.ToString();
                lbl_unit.Text = this.CurrentProduct.unit_name.ToString();

                upateTotal();
                text_quantity.Focus();
                text_quantity.SelectAll();
            }
        }

        private void viewWorkDaySales()
        {
            this.dgv_sales.DataSource = this.repo.GetDaySales(WorkDay);
            NextProcessId = generateProcessID((DataTable)dgv_sales.DataSource);
        }
        private string generateProcessID(DataTable t)
        {
            string last_process_id;
            if (t.Rows.Count == 0)
            {
                LastSerial = 1;
                return WorkDay + "000" + LastSerial.ToString();
            }
            else
            {
                last_process_id = t.Rows[t.Rows.Count - 1][0].ToString();
                LastSerial = int.Parse(last_process_id.Substring(8));
                double day_total = 0;

                foreach (DataRow dr in t.Rows)
                {
                    day_total += double.Parse(dr["total"].ToString());
                }
                dgv_sales.DataSource = t;
                lbl_day_total.Text = day_total.ToString();
                LastSerial++;
                return WorkDay.PadRight(12 - LastSerial.ToString().Length, '0') + (LastSerial).ToString();

            }
        }

        private void updateNextProcessID()
        {
            LastSerial++;
            NextProcessId = WorkDay.PadRight(12 - LastSerial.ToString().Length, '0') + (LastSerial).ToString();
        }

        private void upateTotal()
        {
            double price = 0, quantity = 0;
            double.TryParse(lbl_price.Text, out price);
            double.TryParse(text_quantity.Text, out quantity);
            lbl_total.Text = (price * quantity).ToString();
        }

        private void text_quantity_TextChanged(object sender, EventArgs e)
        {
            double quantity;
            if (!double.TryParse(text_quantity.Text, out quantity) && !text_quantity.Text.Contains('.'))
            {
                text_quantity.Text = "0.0";
                text_quantity.SelectAll();
            }
            upateTotal();
        }

        private void text_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            text_quantity.SelectAll();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            double x;
            if (text_quantity.Text == "0" || !double.TryParse(text_quantity.Text, out x))
                return;
            List<string> data = new List<string>();


            data.Add(NextProcessId);
            data.Add(this.CurrentProduct.ProductID.ToString());

            data.Add(text_quantity.Text);
            data.Add(this.CurrentProduct.selling_price.ToString());

            data.Add(lbl_total.Text);
            data.Add(DateTime.Now.ToString("HH:mm:ss"));
            data.Add(DateTime.Now.Date.ToShortDateString());
            data.Add(this.CurrentProduct.category_id.ToString());

            data.Add(CurrentProduct.unit_id.ToString());

            this.repo.CreateSales(data);

            //DataTable sales_data_table = (DataTable)dgv_sales.DataSource;
            ((DataTable)dgv_sales.DataSource).Rows.Add(this.repo.GetSalesOfProcess(NextProcessId).ItemArray);
            text_quantity.Text = "0";
            text_quantity.Focus();
            text_quantity.SelectAll();
            updateNextProcessID();

            double day_total = double.Parse(lbl_day_total.Text.ToString());
            day_total += double.Parse(dgv_sales.Rows[dgv_sales.Rows.Count - 1].Cells[7].Value.ToString());
            lbl_day_total.Text = day_total.ToString();
            dgv_sales.FirstDisplayedScrollingRowIndex = dgv_sales.Rows.Count - 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void text_quantity_MouseClick_1(object sender, MouseEventArgs e)
        {
            text_quantity.SelectAll();
        }

        private void text_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.PerformClick();
            }
        }


        private int current_row_index;

        private void dgv_sales_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            current_row_index = e.RowIndex;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = dgv_sales.SelectedRows;
            if (selected.Count > 0)
            {
                for (int i = 0; i < selected.Count; i++)
                {
                    this.repo.RemoveSales(selected[i].Cells[0].Value.ToString());
                    dgv_sales.Rows.Remove(selected[i]);
                }
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv_sales.ClearSelection();
                dgv_sales.Rows[current_row_index].Selected = true;

                this.repo.RemoveSales(dgv_sales.Rows[current_row_index].Cells[0].Value.ToString());
                dgv_sales.Rows.RemoveAt(current_row_index);
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dgv_sales.Rows.Count == 0)
            {
                LastSerial = 0;
            }
        }

        private void text_quantity_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        public void dgv_sales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                double day_total = double.Parse(lbl_day_total.Text);
                day_total = day_total - double.Parse(dgv_sales.Rows[e.RowIndex].Cells[7].Value.ToString());
                lbl_day_total.Text = day_total.ToString();
                double amount, price, total;
                string process_id;
                amount = double.Parse(dgv_sales.Rows[e.RowIndex].Cells[5].Value.ToString());
                price = double.Parse(dgv_sales.Rows[e.RowIndex].Cells[6].Value.ToString());
                total = amount * price;
                process_id = dgv_sales.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.repo.UpdateSales(process_id, price, amount, total);
                dgv_sales.Rows[e.RowIndex].Cells[7].Value = total;
                day_total += total;
                lbl_day_total.Text = day_total.ToString();
            }

        }

        private void workDay_ValueChanged(object sender, EventArgs e)
        {
            lbl_work_day.Text = date_picker_work_day.Value.ToString("ddd") + " " + date_picker_work_day.Value.ToString("yyyy/M/d");
            this.WorkDay = date_picker_work_day.Value.ToString("yyyyMMdd");
            viewWorkDaySales();
        }

        private void gbtn_view_products_Click(object sender, EventArgs e)
        {
            FormAllCategoryProducts all = new FormAllCategoryProducts();
            all.SelectedProductChanged += all_SelectedProductChanged;

            all.ProductSaved += all_ProductSaved;

            all.AShowDialog();
        }

        private void all_ProductSaved(object sender, SelectedProductChangedArgs e)
        {
            combo_category_name.Text = e.CategoryName;
            combo_product_name.SelectedValue = e.ProductName;
            text_quantity.Text = e.Amount;
            btn_save.PerformClick();
        }

        private void all_SelectedProductChanged(object sender, SelectedProductChangedArgs e)
        {
            combo_category_name.Text = e.CategoryName;
            combo_product_name.SelectedValue = e.ProductName;
        }

    }
}
