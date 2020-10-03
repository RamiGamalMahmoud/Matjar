using DataAccessLayer;
using QueryBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repos
{
    public class SalesRepo
    {
        private Connection conn;
        public SalesRepo()
        {
            this.conn = new Connection();
        }

        public DataTable GetDaySales(string workDay)
        {
            Query query = new Query();
            query.Select("*")
                .From("sales_view")
                .Where("process_id", "like", $"{workDay}%")
                .OrderBy("process_id");
            return this.conn.GetAll(query.QueryString, query.QueryParams);
        }

        public void CreateSales(List<string> data)
        {
            Query query = new Query();
            string[] columns = { "process_id", "product_id", "amount", "price", "total", "time_of_sale", "date_of_sale", "category_id", "unit_id" };
            query.InsertInto("sales")
                .Values(columns, data.ToArray());
            this.conn.Run(query.QueryString, query.QueryParams);
        }

        public DataRow GetSalesOfProcess(string processId)
        {
            Query query = new Query();
            query.Select("*")
                .From("sales_view")
                .Where("process_id", "=", processId);
            return this.conn.Get(query.QueryString, query.QueryParams);
        }

        public void RemoveSales(string processId)
        {
            Query query = new Query();
            query.Delete()
                .From("sales")
                .Where("process_id", "=", processId);
            this.conn.Run(query.QueryString, query.QueryParams);
        }

        public void UpdateSales(string processId, double price, double amount, double total)
        {
            Query query = new Query();
            string[] columns = { "price", "amount", "total" };
            string[] values = { price.ToString(), amount.ToString(), total.ToString() };
            query.Update("sales")
                .SetValues(columns, values)
                .Where("process_id", "=", processId);
            this.conn.Run(query.QueryString, query.QueryParams);
        }
    }
}
