using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Repos;

namespace UserControls
{
    public partial class SettingPrices : Form
    {
        ProductsRepo repo;
        public SettingPrices()
        {
            InitializeComponent();
            this.repo = new ProductsRepo();
        }


        public virtual void ShowDialog(string product_name_id, string purchasing_unit_id, string purchasing_price)
        {
            Models.PurchasingProcess.ParseUnits(product_name_id, purchasing_unit_id, purchasing_price);
            dgv_product_name_data.DataSource = CreateProductIfoDataTable();
            this.ShowDialog();
        }

        private DataTable CreateProductIfoDataTable()
        {
            DataTable product_info = new DataTable();
            product_info.Columns.Add("product_id");
            product_info.Columns.Add("product_name");
            product_info.Columns.Add("unit");
            product_info.Columns.Add("purchasing_price");
            product_info.Columns.Add("selling_price");
            product_info.Columns.Add("profit_margin");

            List<Models.PurchasedProduct> list = Models.PurchasingProcess.PurchasedProducts;
            for (int i = 0; i < list.Count; i++)
            {
                product_info.Rows.Add(list[i].ProductID, list[i].ProductName, list[i].UnitName, list[i].PurchasingPrice);
            }
            Models.PurchasingProcess.PurchasedProducts.Clear();
            return product_info;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable tbl = (DataTable)dgv_product_name_data.DataSource;
            foreach (DataRow row in tbl.Rows)
            {
                string[] data = { row[3].ToString(), row[4].ToString(), row[5].ToString() };
                string productId = row[0].ToString();
                this.repo.UpdateProduct(data, productId);
            }
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dgv_product_name_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tbl = (DataTable)dgv_product_name_data.DataSource;
            if (tbl != null)
            {
                dgv_product_name_data.CellValueChanged -= dgv_product_name_data_CellValueChanged;
                double purchasing_price, selling_price;
                double.TryParse(dgv_product_name_data.Rows[e.RowIndex].Cells["purchasing_price"].Value.ToString(), out purchasing_price);
                double.TryParse(dgv_product_name_data.Rows[e.RowIndex].Cells["selling_price"].Value.ToString(), out selling_price);

                tbl.Rows[e.RowIndex]["profit_margin"] = selling_price - purchasing_price;
                dgv_product_name_data.CellValueChanged += dgv_product_name_data_CellValueChanged;
            }
        }
    }
}
