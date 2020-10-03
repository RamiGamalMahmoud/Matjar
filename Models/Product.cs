using System.Collections.Generic;

namespace Models
{
    public class Product
    {
        private int product_id;
        private DataAccessLayer.DBHandler db;
        public int ProductID
        {
            get
            {
                return this.product_id;
            }
            set
            {
                this.product_id = value;
                if (this.db == null)
                {
                    this.db = new DataAccessLayer.DBHandler();
                }
                this.getProductData();

            }
        }

        // Database properites
        public int product_name_id { get; private set; }
        public int unit_id { get; private set; }
        public int category_id { get; private set; }

        // View properites
        public string product_name { get; private set; }
        public string unit_name { get; private set; }
        public string category_name { get; private set; }
        public double amount { get; private set; }
        public double selling_price { get; private set; }
        public double purchaning_price { get; private set; }
        public double profit_margin { get; private set; }


        private void getProductData()
        {
            double amount, selling_price, purchaning_price, profit_margin;
            Dictionary<string, string> product_data;
            product_data = this.db.getProductData(this.product_id);

            // Database properites
            this.product_name_id = int.Parse(product_data["product_name_id"]);
            this.unit_id = int.Parse(product_data["unit_id"]);
            this.category_id = int.Parse(product_data["category_id"]);

            // View properites
            this.product_name = product_data["product_name"];
            this.unit_name = product_data["unit"];
            this.category_name = product_data["category"];

            double.TryParse(product_data["amount"], out amount);
            this.amount = amount;

            double.TryParse(product_data["selling_price"],out selling_price);
            this.selling_price = selling_price;

            double.TryParse(product_data["purchasing_price"], out purchaning_price);
            this.purchaning_price = purchaning_price;

            double.TryParse(product_data["profit_margin"], out profit_margin);
            this.profit_margin = profit_margin;
        }
    }
}
