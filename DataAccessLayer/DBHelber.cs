using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DataAccessLayer
{
    public static class DBHelber
    {
        private static SQLiteConnection _connection;
        private static SQLiteConnection Connection
        {
            get
            {
                if (_connection == null) _connection = new SQLiteConnection();
                return _connection;
            }
        }

        private static void Connect()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.ConnectionString = DBHandler.LoadConnectionString("MatjarDatabase");
                Connection.Open();
            }
        }

        private static void Stop()
        {
            if (Connection != null && Connection.State != ConnectionState.Closed) Connection.Close();
        }

        private static bool IsConnected()
        {
            Connect();
            return Connection.State == ConnectionState.Open;
        }

        private static DataTable Exec(string query, List<SqlParameter> parameters)
        {
            if (!IsConnected()) return null;

            DataTable result = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand(query, Connection);
            if (parameters != null)
            {
                foreach (SqlParameter par in parameters)
                {
                    cmd.Parameters.Add(new SQLiteParameter(par.ParameterName, par.Value));
                }
            }

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
            {
                using (DataTable tbl_categories = new DataTable())
                {
                    adapter.Fill(result);
                }
            }
            return result;
        }

        private static DataTable ExecuteQuery(string query)
        {
            if (!IsConnected()) return null;

            DataTable result = new DataTable();

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, Connection))
            {
                using (DataTable tbl_categories = new DataTable())
                {
                    try
                    {
                        adapter.Fill(result);
                    }
                    catch (SQLiteException sqlite_exception)
                    {
                        result = null;
                    }
                }
            }
            return result;
        }
        private static int ExecuteNonQuery(string query)
        {
            if (!IsConnected()) return 0;
            int result = 0;
            using (SQLiteCommand cmd = new SQLiteCommand(query, Connection))
            {
                try
                {
                    result = cmd.ExecuteNonQuery();
                }

                catch (SQLiteException sqlite_exception)
                {
                    result = 0;
                }
            }
            return result;
        }
        // SELECT [get categories]
        public static DataTable Categories()
        {
            //Query.Query query = new Query.Query();
            //query.Select("id, category ")
            //  .From("categories");

            return null;
        }

        // SELECT [get Units]
        public static DataTable Units()
        {
            //var query = new Query.Query();
            //query.Select("id, unit")
            //    .From("units")
            //    .OrderBy("unit", Query.SordOrder.ASC);
            return null;
        }

        // get product id from product name and unit
        public static string GetProductId(string product_name_id, string unit_id)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(QueriesStrings.ProductID(product_name_id, unit_id), Connection))
            {
                return (string)cmd.ExecuteScalar();
            }
        }

        public static DataTable GetYears()
        {
            return DBHelber.ExecuteQuery(QueriesStrings.YearsQuery());
        }

        public static DataTable GetMonthesOfYear(string year_id)
        {
            return DBHelber.ExecuteQuery(QueriesStrings.MonthesForYear(year_id));
        }

        public static DataTable GetCategoryProducts(string category_id)
        {
            return DBHelber.ExecuteQuery(QueriesStrings.CategoryProductsQuery(category_id));
        }

        public static DataTable GetProductNameData(string product_name_id)
        {
            return DBHelber.ExecuteQuery(QueriesStrings.ProductNameDataQuery(product_name_id));
        }

        public static DataTable GetUnitsInfo(string product_name_id)
        {
            return DBHelber.ExecuteQuery(QueriesStrings.UnitsInfoQuery(product_name_id));
        }
        public static DataTable GetProduct(int product_id)
        {
            string query = "";
            return DBHelber.ExecuteQuery(query);
        }

        public static DataTable GetAllProducts(string category_id)
        {
            string query = string.Format("SELECT * FROM products_data_view ");
            if (category_id != "0")
                query += string.Format("WHERE category_id = {0}", category_id);
            return DBHelber.ExecuteQuery(query);
        }




        public static DataTable GetDaySales(string start_date)
        {
            //Query.Query query = new Query.Query();
            //query.Select("*")
            //    .From("sales_view")
            //    .Where("process_id", "like", $"{start_date}%")
            //    .OrderBy("process_id");
            //string query = string.Format("SELECT * FROM sales_view WHERE process_id LIKE '{0}____' ORDER BY process_id", start_date);
            return null;
        }

        // Get the sales table for a process id
        public static DataTable GetProcessSales(string process_id)
        {
            string query = string.Format("SELECT * FROM sales_view WHERE process_id = {0}", process_id);
            return DBHelber.ExecuteQuery(query);
        }

        // get units for product name in purchases table
        public static DataTable GetProductUnitsInfo(string product_name_id)
        {
            DataTable baseQueryResult = DBHelber.ExecuteQuery(QueriesStrings.BaseUnitQuery(product_name_id));
            DataTable subQueryResult = DBHelber.ExecuteQuery(QueriesStrings.SubUnitQuery(product_name_id));

            baseQueryResult.Merge(subQueryResult);
            return baseQueryResult;
        }

        public static DataTable GetPurchases(string year, string month)
        {
            return DBHelber.ExecuteQuery(QueriesStrings.PurchasesQuery(year, month));
        }


        public static DataTable GetProductData(string product_id)
        {
            string query = "";
            return DBHelber.ExecuteQuery(query);
        }
        // INSERT
        // UPDATE
        // DELETE
    }
}
