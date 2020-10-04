using System;

namespace Models
{
    public class Product
    {
        public int ProductID { get; set; }

        // Database properites
        public int ProductNameId { get; set; }
        public int UnitId { get; set; }
        public int CategoryId { get; set; }

        // View properites
        public string ProductName { get; set; }
        public string UnitName { get; set; }
        public string CategoryName { get; set; }
        public double Amount { get; set; }
        public double SellingPrice { get; set; }
        public double PurchaningPrice { get; set; }
        public double ProfitMargin { get; set; }

        public Product Clone()
        {
            Product product = new Product();
            product.ProductID = this.ProductID;
            product.ProductNameId = this.ProductNameId;
            product.UnitId = this.UnitId;
            product.ProductName = this.ProductName;
            product.UnitId = this.UnitId;
            product.UnitName = this.UnitName;
            product.CategoryId = this.CategoryId;
            product.CategoryName = this.CategoryName;
            product.Amount = this.Amount;
            product.SellingPrice = this.SellingPrice;
            product.PurchaningPrice = this.PurchaningPrice;
            product.ProfitMargin = this.ProfitMargin;
            return product;
        }

    }
}
