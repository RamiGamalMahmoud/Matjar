using DataAccessLayer;
using System;
using QueryBuilder;
using System.Data;

namespace Repos
{
    public class ProductsRepo : IDisposable
    {
        private Connection conn;
        public ProductsRepo()
        {
            this.conn = new Connection();
        }
        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable UpdateProduct(string[] data, string productId)
        {
            using (Query query = new Query())
            {
                string[] columns = { "selling_price", "purchasing_price", "profit_margin" };
                query.Update("products")
                    .SetValues(columns, data)
                    .Where("product_id", "=", productId);
                int result = this.conn.Run(query.QueryString, query.QueryParams);
                Console.WriteLine(query.QueryString);
                Console.WriteLine(result);
            }

            return null;
        }

        public DataTable GetAllProducts()
        {
            using (Query query = new Query())
            {
                query.Select("*")
                    .From("products_data_view");
                return this.conn.GetAll(query.QueryString);
            }
        }

        public DataTable GetCategoryProducts(string categoryId)
        {
            using (Query query = new Query())
            {
                query.Select("category_id, category AS category_name, product_id, product_name, unit AS unit_name, unit_id, selling_price, amount")
                    .From("products_data_view")
                    .Where("category_id", "=", categoryId)
                    .OrderBy("product_name", SordOrder.ASC);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }

        public DataTable GetProductsByName(string name)
        {
            using (Query query = new Query())
            {
                query.Select("category_id, category AS category_name, product_id, product_name, unit AS unit_name, unit_id, selling_price, amount")
                    .From("products_data_view")
                    .Where("product_name", "like", $"%{name}%")
                    .OrderBy("product_name", SordOrder.ASC);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }
    }
}
