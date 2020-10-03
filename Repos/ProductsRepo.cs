using DataAccessLayer;
using System;
using QueryBuilder;
using System.Data;
using System.Collections.Generic;
using Models;

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
                query.Select("category_id, category AS category_name, product_id, product_name, product_name_id, unit AS unit_name, unit_id, selling_price, amount")
                    .From("products_data_view")
                    .Where("category_id", "=", categoryId)
                    .OrderBy("product_name", SordOrder.ASC);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }

        public DataTable GetProductsNamesByCategory(string categoryId)
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

        public DataTable GetProductsByNameId(string productNameId)
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

        public Product GetProductById(string productId)
        {
            using (Query query = new Query())
            {
                query.Select("product_name, amount, selling_price, purchasing_price, profit_margin, product_name_id, unit_id, category_id, unit, category")
                    .From("products_data_view")
                    .Where("product_id", "=", productId);
                return this.ExtractProductData(this.conn.Get(query.QueryString, query.QueryParams));
            }
        }

        private Product ExtractProductData(DataRow data)
        {
            Product product = new Product();

            double amount, selling_price, purchaning_price, profit_margin;

            // Database properites
            product.UnitId = int.Parse(data["unit_id"].ToString());
            product.CategoryId = int.Parse(data["category_id"].ToString());
            product.ProductNameId = int.Parse(data["product_name_id"].ToString());

            // View properites
            product.ProductName = data["product_name"].ToString();
            product.UnitName = data["unit"].ToString();
            product.CategoryName = data["category"].ToString();

            double.TryParse(data["amount"].ToString(), out amount);
            product.Amount = amount;

            double.TryParse(data["selling_price"].ToString(), out selling_price);
            product.SellingPrice = selling_price;

            double.TryParse(data["purchasing_price"].ToString(), out purchaning_price);
            product.PurchaningPrice = purchaning_price;

            double.TryParse(data["profit_margin"].ToString(), out profit_margin);
            product.ProfitMargin = profit_margin;

            return product;
        }
    }
}
