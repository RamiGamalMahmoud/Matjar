using System;

namespace Models
{
    public class PurchasedProduct
    {
        private string product_name_id;
        private string product_name;
        private string unit_id;
        private string unit_name;
        private double purchasing_price;
        private string product_id;

        public string ProductNameID
        {
            get { return this.product_name_id; }
            set { this.product_name_id = value; }
        }
        public string ProductName
        {
            get { return this.product_name; }
            set { this.product_name = value; }
        }
        public string UnitID
        {
            get { return this.unit_id; }
            set
            {
                this.unit_id = value;
                this.GetAllProductData();
            }
        }
        public string UnitName
        {
            get { return this.unit_name; }
            set { this.unit_name = value; }
        }
        public double PurchasingPrice
        {
            get { return this.purchasing_price; }
            set { this.purchasing_price = value; }
        }
        public string ProductID
        {
            get { return this.product_id; }
            set { this.product_id = value; }
        }

        public void GetAllProductData()
        {
            DataAccessLayer.DBHandler db = new DataAccessLayer.DBHandler();
            string query = string.Format(@"SELECT products.product_id, products_names.product_name, units.unit FROM products
                                            JOIN 
                                                products_names ON products.product_name_id = products_names.product_name_id
                                            JOIN
                                                units ON products.unit_id = units.id
                                            WHERE 
                                                products.product_name_id = {0} 
                                            AND
                                                products.unit_id = {1}", this.ProductNameID, this.UnitID);
            System.Data.DataRow row = db.ExecuteSQLOneRow(query);
            this.ProductName = row["product_name"].ToString();
            this.UnitName = row["unit"].ToString();
            this.ProductID = row["product_id"].ToString();
        }
    }
}
