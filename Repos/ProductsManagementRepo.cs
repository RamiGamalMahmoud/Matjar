using DataAccessLayer;
using QueryBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repos
{
    public class ProductsManagementRepo : IDisposable
    {
        private Connection conn;
        public ProductsManagementRepo()
        {
            this.conn = new Connection();
        }

        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable GetCategoryProducts(string categoryId)
        {
            using (Query query = new Query())
            {
                query.Select("product_name_id, product_name")
                    .From("products_names")
                    .Where("category_id", "=", categoryId)
                    .OrderBy("product_name");
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }

        public DataTable GetProductNameData(string productNameId)
        {
            using (Query query = new Query())
            {
                query.Select("product_id, unit, amount, purchasing_price, selling_price, profit_margin")
                    .From("products_data_view")
                    .Where("product_name_id", "=", productNameId)
                    .OrderBy("purchasing_price", SordOrder.DESC);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }

        public DataTable GetUnitsInfo(string productNameId)
        {
            using (Query query = new Query())
            {
                query.Select("info_id, base_unit_name, base_unit_id, sub_unit_name, sub_unit_id, sub_unit_count, sub_unit_is_purchaseable")
                    .From("units_info_view")
                    .Where("product_name_id", "=", productNameId);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }

        public void CreateProductName(string productName, string categoryId)
        {
            using (Query query = new Query())
            {
                query.InsertInto("products_names")
                    .Values(new string[] { "product_name_id, product_name", "category_id" }, new string[] { "NULL", productName, categoryId });
                this.conn.Run(query.QueryString, query.QueryParams);
            }
        }

        public void CreateNewProduct(List<string> data)
        {
            using (Query query = new Query())
            {
                string[] columns = { "product_id", "amount", "selling_price", "purchasing_price", "profit_margin", "product_name_id", "category_id", "unit_id" };
                query.InsertInto("products")
                    .Values(columns, data.ToArray());
            }
        }

        public void UpdateProduct(List<string> data, string productId)
        {

        }
    }
}
