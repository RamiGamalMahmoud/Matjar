using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Models;
using Repos;

namespace UserControls
{
    public partial class SettingPrices : Form
    {
        readonly ProductsRepo productsRepo;
        readonly UnitsContentsRepo unitsContentsRepo;
        public SettingPrices()
        {
            this.InitializeComponent();
            this.productsRepo = new ProductsRepo();
            this.unitsContentsRepo = new UnitsContentsRepo();
        }

        public virtual void ShowDialog(Product purchasedProduct)
        {
            List<Product> products = new List<Product>();
            products.Add(purchasedProduct);
            DataTable infos = this.unitsContentsRepo.GetUnitsInfo(purchasedProduct.ProductNameId.ToString());

            this.ParseUnits(purchasedProduct, infos, products);
            this.dgv_product_name_data.DataSource = this.PrepareProducts(products);

            this.ShowDialog();
        }

        private void ParseUnits(Product purchasedProduct, DataTable infos, List<Product> output)
        {
            Product prod = purchasedProduct.Clone();


            foreach (DataRow info in infos.Rows)
            {
                if (info["base_unit_id"].ToString() == purchasedProduct.UnitId.ToString())
                {
                    prod.UnitId = int.Parse(info["sub_unit_id"].ToString());
                    double count = double.Parse(info["sub_unit_count"].ToString());
                    prod.PurchaningPrice = Math.Round(purchasedProduct.PurchaningPrice / count, 2);
                    prod.Amount = purchasedProduct.Amount * count;
                    output.Add(prod);
                    this.ParseUnits(prod, infos, output);
                }
            }
        }

        private DataTable PrepareProducts(List<Product> products)
        {
            DataTable product_info = new DataTable();
            product_info.Columns.Add("product_id");
            product_info.Columns.Add("product_name");
            product_info.Columns.Add("unit");
            product_info.Columns.Add("purchasing_price");
            product_info.Columns.Add("selling_price");
            product_info.Columns.Add("profit_margin");

            foreach (Product product in products)
            {
                DataRow result = this.productsRepo.GetProductByNameIdAndUnitId(product.ProductNameId.ToString(),
                    product.UnitId.ToString());
                if (result != null)
                    product_info.Rows.Add(
                        result["product_id"],
                        result["product_name"],
                        result["unit"],
                        product.PurchaningPrice,
                        "0",
                        "0"
                        );
            }

            return product_info;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable tbl = (DataTable)this.dgv_product_name_data.DataSource;
            foreach (DataRow row in tbl.Rows)
            {
                string[] data = { row["purchasing_price"].ToString(), row["selling_price"].ToString(), row["profit_margin"].ToString() };
                string productId = row[0].ToString();
                this.productsRepo.UpdateProduct(data, productId);
            }
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dgv_product_name_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tbl = (DataTable)this.dgv_product_name_data.DataSource;
            if (tbl != null)
            {
                this.dgv_product_name_data.CellValueChanged -= this.dgv_product_name_data_CellValueChanged;
                double purchasing_price, selling_price;
                double.TryParse(this.dgv_product_name_data.Rows[e.RowIndex].Cells["purchasing_price"].Value.ToString(), out purchasing_price);
                double.TryParse(this.dgv_product_name_data.Rows[e.RowIndex].Cells["selling_price"].Value.ToString(), out selling_price);

                tbl.Rows[e.RowIndex]["profit_margin"] = selling_price - purchasing_price;
                this.dgv_product_name_data.CellValueChanged += this.dgv_product_name_data_CellValueChanged;
            }
        }
    }
}
