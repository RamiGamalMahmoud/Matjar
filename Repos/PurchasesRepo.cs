using DataAccessLayer;
using QueryBuilder;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repos
{
    public class PurchasesRepo : IDisposable
    {
        private Connection conn;
        public PurchasesRepo()
        {
            this.conn = new Connection();
        }

        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable GetAllCategories()
        {
            Query query = new Query();
            query.Select("id, category ")
              .From("categories");
            return this.conn.GetAll(query.QueryString);
        }

        public DataTable GetAllUnits()
        {
            Query query = new Query();
            query.Select("id, unit")
                .From("units")
                .OrderBy("unit", SordOrder.ASC);
            return this.conn.GetAll(query.QueryString);
        }

        public DataTable GetYears()
        {
            Query query = new Query();
            query.Select("DISTINCT  year")
                .From("purchases_monthes")
                .OrderBy("year", SordOrder.DESC);
            return this.conn.GetAll(query.QueryString);
        }

        public DataTable GetMonthesOfYear(string yearId)
        {
            Query query = new Query();
            query.Select("monthes")
                .From("purchases_monthes")
                .Where("year", "=", yearId)
                .OrderBy("monthes", SordOrder.DESC);
            return this.conn.GetAll(query.QueryString, query.QueryParams);
        }

        public DataTable GetCategoryProducts(string categoryId)
        {
            Query query = new Query();
            query.Select("*")
                .From("products_data_view")
                .Where("category_id", "=", categoryId)
                .OrderBy("product_name");
            return this.conn.GetAll(query.QueryString, query.QueryParams);
        }

        public DataTable GetProductUnitsInfo(string productNameId)
        {
            DataTable baseUnits = this.GetBaseUnits(productNameId);
            DataTable subUnits = this.GetSubUnits(productNameId);
            baseUnits.Merge(subUnits);
            return baseUnits;
        }

        public DataTable GetBaseUnits(string productNameId)
        {
            Query query = new Query();
            query.Select("units.id AS unit_id, units.unit AS unit_name")
                .From("products_units_info")
                .Join("units")
                .On("products_units_info.base_unit_id", "units.id ")
                .Where("products_units_info.product_name_id", "=", productNameId)
                .OrderBy("unit_name");
            return this.conn.GetAll(query.QueryString, query.QueryParams);
        }

        public DataTable GetSubUnits(string productNameId)
        {
            Query query = new Query();
            query.Select("units.id AS unit_id, units.unit AS unit_name")
                .From("products_units_info")
                .Join("units")
                .On("products_units_info.sub_unit_id", "units.id ")
                .Where("products_units_info.product_name_id", "=", productNameId)
                .AndWhere("products_units_info.sub_unit_is_purchaseable", "=", "نعم")
                .OrderBy("unit_name");
            return this.conn.GetAll(query.QueryString, query.QueryParams);
        }

        public int SavePurchasedProduct(List<string> data)
        {
            string[] columns = { "category_id", "product_name_id", "unit_id", "unit_price", "amount", "total", "purchase_date" };
            Query query = new Query();
            query.InsertInto("purchases")
                .Values(columns, data.ToArray());
            return this.conn.Run(query.QueryString, query.QueryParams);
        }

        public void UpdateMonthes(string year, string month)
        {
            Query query = new Query();
            query.Select("1")
                .From("purchases_monthes")
                .Where("year", "=", year)
                .AndWhere("monthes", "=", month);
            if (!this.conn.IsExists(query.QueryString, query.QueryParams))
            {
                query.Clear();
                query.InsertInto("purchases_monthes")
                    .Values(new string[] {"year", "monthes" }, new string[] {year, month });
                this.conn.Run(query.QueryString, query.QueryParams);
            }
        }

        public DataTable GetPurchases(string year, string month)
        {
            Query query = new Query();
            query.Select("*")
                .From("purchases_view")
                .Where("purchases_view.purchase_date", "like", string.Format("{0}/{1}/%", year, month));
            return this.conn.GetAll(query.QueryString, query.QueryParams);
        }
    }
}
