using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Repos;
using Models;


namespace UserControls
{
    public partial class UC_Sales : UserControl
    {
        private SalesRepo repo;
        private ProductsRepo productsRepo;
        private int CurrentRowIndex;

        private Product CurrentProduct;
        private readonly Timer timer = new Timer() { Interval = 10 };

        public int LastSerial { get; set; }
        public string WorkDay { get; set; }
        public string NextProcessId { get; set; }

        public UC_Sales()
        {
            this.InitializeComponent();
        }

        private void UC_DailySales_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in this.DgvSales.Columns)
            {
                col.ContextMenuStrip = this.dgvDailySalesProperties;
            }

            this.ComboCategoryName.DisplayMember = "category";
            this.ComboCategoryName.ValueMember = "id";
            this.ComboProductName.DisplayMember = "product_name";
            this.ComboProductName.ValueMember = "product_id";
            this.DgvSales.DoubleBuffered(true);
            this.LblWorkDay.Text = this.DatePickerWork_day.Value.ToString("ddd") + " " + this.DatePickerWork_day.Value.ToString("yyyy/M/d");
            this.WorkDay = this.DatePickerWork_day.Value.ToString("yyyyMMdd");
        }

        public void Start()
        {
            this.repo = new SalesRepo();
            this.productsRepo = new ProductsRepo();

            this.DatePickerWork_day.Value = DateTime.Now.Date;

            this.ViewWorkDaySales(this.DatePickerWork_day.Value.ToShortDateString());

            using (CategoriesRepo categoriesRepo = new CategoriesRepo())
            {
                this.ComboCategoryName.DataSource = categoriesRepo.GetCategories();
            }

            this.BindEvents();
            this.timer.Start();
        }

        private void BindEvents()
        {
            this.DgvSales.CellValueChanged += this.DgvSalesCellValueChanged;
            this.timer.Tick += this.TimerTick;
            this.ComboCategoryName.SelectedValueChanged += this.ComboCategoryNameSelectedValueChanged;
            this.ComboCategoryNameSelectedValueChanged(this.ComboCategoryName, EventArgs.Empty);
            this.ComboProductName.SelectedValueChanged += this.ComboProductNameSelectedValueChanged;
            this.ComboProductNameSelectedValueChanged(this.ComboProductName, EventArgs.Empty);
        }

        private void ViewWorkDaySales(string date)
        {
            this.DgvSales.DataSource = this.repo.GetSalesByDate(date);
        }

        private void UpateTotal()
        {
            double.TryParse(this.LblPrice.Text, out double price);
            double.TryParse(this.TextQuantity.Text, out double quantity);
            this.LblTotal.Text = (price * quantity).ToString();
        }

        private void TextQuantityTextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextQuantity.Text, out _) && !this.TextQuantity.Text.Contains('.'))
            {
                this.TextQuantity.Text = "0.0";
                this.TextQuantity.SelectAll();
            }
            this.UpateTotal();
        }

        private void TextQuantityMouseClick(object sender, MouseEventArgs e)
        {
            this.TextQuantity.SelectAll();
        }

        private void ComboCategoryNameSelectedValueChanged(object sender, EventArgs e)
        {
            this.LblCategoryId.Text = this.ComboCategoryName.SelectedValue.ToString();
            this.ComboProductName.DataSource = this.productsRepo.GetCategoryProducts(this.ComboCategoryName.SelectedValue.ToString());
        }


        private void ComboProductNameSelectedValueChanged(object sender, EventArgs e)
        {

            if (this.ComboProductName.SelectedValue != null)
            {
                this.LblProductId.Text = this.ComboProductName.SelectedValue.ToString();

                string currentProductId = this.ComboProductName.SelectedValue.ToString();
                this.CurrentProduct = this.productsRepo.GetProductById(this.ComboProductName.SelectedValue.ToString());
                this.CurrentProduct.ProductID = int.Parse(currentProductId);

                this.LblPrice.Text = this.CurrentProduct.SellingPrice.ToString();
                this.LblUnit.Text = this.CurrentProduct.UnitName.ToString();


                this.UpateTotal();
                this.TextQuantity.Focus();
                this.TextQuantity.SelectAll();
            }
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            if (this.TextQuantity.Text == "0" || !double.TryParse(this.TextQuantity.Text, out _))
                return;
            List<string> data = this.GetSoldData();
            DataRow lastInsertedRow = this.repo.CreateSales(data);
            if (lastInsertedRow != null)
                this.UpdateSalesView(lastInsertedRow);
        }

        private List<string> GetSoldData()
        {
            return new List<string>
            {
                this.CurrentProduct.ProductID.ToString(),

                this.TextQuantity.Text,
                this.CurrentProduct.SellingPrice.ToString(),

                this.LblTotal.Text,
                DateTime.Now.ToString("HH:mm:ss"),
                DateTime.Now.Date.ToShortDateString(),
                this.CurrentProduct.CategoryId.ToString(),

                this.CurrentProduct.UnitId.ToString()
            };
        }

        private void UpdateSalesView(DataRow insertedRow)
        {
            ((DataTable)this.DgvSales.DataSource).ImportRow(insertedRow);
            this.TextQuantity.Text = "0";
            this.TextQuantity.Focus();
            this.TextQuantity.SelectAll();

            double DayTotal = double.Parse(this.LblDayTotal.Text.ToString());
            DayTotal += double.Parse(this.DgvSales.Rows[this.DgvSales.Rows.Count - 1].Cells[7].Value.ToString());
            this.LblDayTotal.Text = DayTotal.ToString();
            this.DgvSales.FirstDisplayedScrollingRowIndex = this.DgvSales.Rows.Count - 1;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.LblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void TextQuantityClicked(object sender, MouseEventArgs e)
        {
            this.TextQuantity.SelectAll();
        }

        private void TextQuantityKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnSave.PerformClick();
            }
        }

        private void DgvSalesCellMouseClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.CurrentRowIndex = e.RowIndex;
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = this.DgvSales.SelectedRows;
            if (selected.Count > 0)
            {
                for (int i = 0; i < selected.Count; i++)
                {
                    this.repo.RemoveSales(selected[i].Cells[0].Value.ToString());
                    this.DgvSales.Rows.Remove(selected[i]);
                }
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.DgvSales.ClearSelection();
                this.DgvSales.Rows[this.CurrentRowIndex].Selected = true;

                this.repo.RemoveSales(this.DgvSales.Rows[this.CurrentRowIndex].Cells[0].Value.ToString());
                this.DgvSales.Rows.RemoveAt(this.CurrentRowIndex);
                MessageBox.Show("تم الحذف", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (this.DgvSales.Rows.Count == 0)
            {
                this.LastSerial = 0;
            }
        }

        public void DgvSalesCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                double dayTotal = double.Parse(this.LblDayTotal.Text);
                dayTotal = dayTotal - double.Parse(this.DgvSales.Rows[e.RowIndex].Cells[7].Value.ToString());
                this.LblDayTotal.Text = dayTotal.ToString();
                double amount, price, total;
                string processId;
                amount = double.Parse(this.DgvSales.Rows[e.RowIndex].Cells[5].Value.ToString());
                price = double.Parse(this.DgvSales.Rows[e.RowIndex].Cells[6].Value.ToString());
                total = amount * price;
                processId = this.DgvSales.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.repo.UpdateSales(processId, price, amount, total);
                this.DgvSales.Rows[e.RowIndex].Cells[7].Value = total;
                dayTotal += total;
                this.LblDayTotal.Text = dayTotal.ToString();
            }

        }

        private void WorkDayValueChanged(object sender, EventArgs e)
        {
            this.LblWorkDay.Text = this.DatePickerWork_day.Value.ToString("ddd") + " " + this.DatePickerWork_day.Value.ToString("yyyy/M/d");
            this.WorkDay = this.DatePickerWork_day.Value.ToString("yyyyMMdd");
            this.ViewWorkDaySales(this.DatePickerWork_day.Value.ToShortDateString());
        }

        private void GbtnViewProductsClick(object sender, EventArgs e)
        {
            FormAllCategoryProducts all = new FormAllCategoryProducts();
            all.SelectedProductChanged += this.AllSelectedProductChanged;

            all.ProductSaved += this.AllProductSaved;

            all.AShowDialog();
        }

        private void AllProductSaved(object sender, SelectedProductChangedArgs e)
        {
            this.ComboCategoryName.Text = e.CategoryName;
            this.ComboProductName.SelectedValue = e.ProductName;
            this.TextQuantity.Text = e.Amount;
            this.BtnSave.PerformClick();
        }

        private void AllSelectedProductChanged(object sender, SelectedProductChangedArgs e)
        {
            this.ComboCategoryName.Text = e.CategoryName;
            this.ComboProductName.SelectedValue = e.ProductName;
        }

    }
}
