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
    }
}
