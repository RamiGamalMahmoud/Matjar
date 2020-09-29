using System;
using System.Data;
using DataAccessLayer;
using System.Collections.Generic;
using System.Globalization;


namespace Models
{

    public static class PurchasingProcess
    {
        private static DBHandler db = new DBHandler();
        private static List<PurchasedProduct> purchased_products = new List<PurchasedProduct>();
        public static List<PurchasedProduct> PurchasedProducts
        {
            get { return purchased_products; }
            private set { purchased_products = value; }
        }


        public static void ParseUnits(string product_name_id, string purchasing_unit_id, string purchasing_price)
        {
            string query = string.Format("SELECT * FROM products WHERE product_name_id = {0} AND unit_id = {1}",
                product_name_id,
                purchasing_unit_id);
            DataRow row = db.ExecuteSQLOneRow(query);
            if(row != null )
            {
                PurchasedProduct purchased_product = new PurchasedProduct();
                purchased_product.ProductNameID = product_name_id;
                purchased_product.UnitID = purchasing_unit_id;
                purchased_product.PurchasingPrice = double.Parse(purchasing_price);
                purchased_products.Add(purchased_product);
            }
            ParseFromUnitsInfo(product_name_id, purchasing_unit_id, purchasing_price);
        }

        public static void ParseFromUnitsInfo(string product_name_id, string purchasing_unit_id, string purchasing_price)
        {
            PurchasedProduct purchased_product = new PurchasedProduct();
            string sql_query = string.Format(@"SELECT * FROM products_units_info WHERE product_name_id = {0} AND base_unit_id = {1}",
                product_name_id,
                purchasing_unit_id);

            DataRow row = db.ExecuteSQLOneRow(sql_query);
            if ( row != null )
            {
                purchased_product.ProductNameID = product_name_id;

                double price;
                double.TryParse(purchasing_price, out price);
                int count;
                int.TryParse(row["sub_unit_count"].ToString(), out count);
                
                purchased_product.PurchasingPrice = (price / count);
                purchased_product.PurchasingPrice = double.Parse(string.Format("{0:0.00}", purchased_product.PurchasingPrice));
                purchased_product.UnitID = row["sub_unit_id"].ToString();
                purchased_products.Add(purchased_product);

                ParseFromUnitsInfo(product_name_id, purchased_product.UnitID, purchased_product.PurchasingPrice.ToString());
            }
        }

    }
}
