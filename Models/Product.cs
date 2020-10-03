using System.Collections.Generic;

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

    }
}
