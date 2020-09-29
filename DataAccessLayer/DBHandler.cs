using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;


namespace DataAccessLayer
{
    // My Extensions class 
    public static class Extension
    {
        public static List<string> ColumnToArray(this DataTable tbl, int indx)
        {
            List<string> array = new List<string>();
            foreach (DataRow row in tbl.Rows)
            {
                array.Add(row[indx].ToString());
            }
            return array;
        }
    }

    // DataBase Handler class 

    public class DBHandler
    {
        private SQLiteConnection Connection { get; set; }


        public DBHandler()
        {
            Connection = new SQLiteConnection(LoadConnectionString());
            Connection.Open();
        }

        public static string LoadConnectionString(string connection_string = "MatjarDatabase")
        {
            return ConfigurationManager.ConnectionStrings[connection_string].ConnectionString;
        }

        // 
        public DataTable ExecuteSQL(string sql)
        {
            DataTable result = new DataTable();
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, Connection))
            {
                adapter.Fill(result);
            }
            return result;
        }

        public string ExecuteNonQuery(string query)
        {
           
            using (SQLiteCommand cmd = new SQLiteCommand(query, Connection))
            {
                try
                {
                    return cmd.ExecuteNonQuery().ToString();
                }
                catch (SQLiteException sqlite_exception)
                {
                    return sqlite_exception.ResultCode.ToString();
                }
            }
        }
        public DataRow ExecuteSQLOneRow(string sql)
        {
            DataTable tbl = new DataTable();
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, Connection))
            {
                adapter.Fill(tbl);
            }
            if (tbl.Rows.Count > 0)
                return tbl.Rows[0];
            else return null;
        }

        // insert data into sales table for the date
        public void insertDataIntoTable(List<string> data, string table_name)
        {
            string text = "INSERT OR IGNORE INTO {0} VALUES ( ";

            string sql = string.Format(text, table_name);
            for (int i = 0; i < data.Count; i++)
            {
                sql += "\"";
                sql += data[i];
                sql += "\"";

                if (i < data.Count - 1)
                    sql += ",";
            }
            sql += " );";

            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException sql_ex)
            {
                Console.WriteLine(sql_ex.Message);
            }
        }




        // Delete inserted data
        public void DeleteData(string table_name, string id)
        {
            string sql = "DELETE FROM " + table_name + " WHERE process_id = " + id;
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection))
                cmd.ExecuteNonQuery();
        }

        public void deleteData(string table_name, string id_column, string id)
        {
            string sql = "DELETE FROM " + table_name + " WHERE " + id_column + " = " + id;
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection))
                cmd.ExecuteNonQuery();
        }


        // update sales table 
        public void UpdateSalesTable(double quantity, double price, double total, string process_id)
        {
            string sql = string.Format("UPDATE sales SET amount = {0} ,price = {1}, total = {2} WHERE process_id = {3}", quantity, price, total, process_id);
            using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection))
            {
                cmd.ExecuteNonQuery();
            }
        }


        // new work
        public Dictionary<string, string> getProductData(int product_id)
        {
            List<string> data = new List<string>();
            string sql =
                        @"SELECT products.product_id,
                               products_names.product_name,
                               products.amount,
                               products.selling_price,
                               products.purchasing_price,
                               products.profit_margin,
                               products.product_name_id,
                               products.unit_id,
                               products.category_id,
                               units.unit,
                               categories.category
                          FROM products
                               JOIN
                               products_names ON products.product_name_id = products_names.product_name_id
                               JOIN
                               units ON products.unit_id = units.id
                               JOIN
                               categories ON products.category_id = categories.id
                         WHERE products.product_id = ";
            sql += product_id.ToString();
            Dictionary<string, string> product_data = new Dictionary<string, string>();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            data.Add(reader.GetValue(i).ToString());
                            product_data.Add(reader.GetName(i), reader.GetValue(i).ToString());
                        }
                    }
                }
            }
            catch { }
            return product_data;
        }



        // End of new work


        // will be deleted

        //public DataTable ExecuteSelect(string sql)
        //{
        //    DataTable data = new DataTable();
        //    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
        //    try
        //    {
        //        adapter.Fill(data);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return data;
        //}

        //public DataTable select(string table_name)
        //{
        //    string sql = string.Format("SELECT * FROM {0}", table_name);
        //    return ExecuteSelect(sql);
        //}

        //public DataTable select(string table_name, string order_by)
        //{
        //    string sql = "SELECT * FROM " + table_name + " ORDER BY " + order_by;
        //    return ExecuteSelect(sql);
        //}



        //public DataTable select(string[] columns, string table_name, string order_by)
        //{
        //    string sql = "SELECT ";
        //    string cols = " ";
        //    for (int i = 0; i < columns.Length; i++)
        //    {
        //        cols += columns[i];
        //        if (i < columns.Length - 1)
        //            cols += ",";
        //        cols += " ";
        //    }

        //    sql += cols +
        //        " FROM " + table_name +
        //        " ORDER BY " + order_by;
        //    return ExecuteSelect(sql);
        //}

        //public DataTable select(string[] columns, string table_name, string conditoin_name, string condition_value)
        //{
        //    string sql = "SELECT ";
        //    string cols = " ";
        //    for (int i = 0; i < columns.Length; i++)
        //    {
        //        cols += columns[i];
        //        if (i < columns.Length - 1)
        //            cols += ",";
        //        cols += " ";
        //    }

        //    sql += cols +
        //        " FROM " + table_name +
        //        " WHERE " + conditoin_name + " = " + "\"" + condition_value + "\"";
        //    return ExecuteSelect(sql);
        //}



        // Update data in store table 
        //public void updateData(string col_name, string value, string key)
        //{
        //    string sql = string.Format("UPDATE store SET {0} = {1} WHERE product_id = {2}", col_name, value, key);
        //    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
        //    cmd.ExecuteNonQuery();
        //}

        // insert data into purchases table 
        //private void ExecuteInsert(string sql)
        //{
        //    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
        //    cmd.ExecuteNonQuery();
        //}
        //public void Insert(string tableName, string[] columns, DataRow data)
        //{
        //    string sql = "INSERT INTO " + tableName + " ( ";

        //    foreach (string str in columns)
        //    {
        //        sql += str;

        //        if (columns.Last() != str)
        //            sql += ", ";
        //    }

        //    sql += " ) VALUES (";
        //    for (int i = 0; i < data.ItemArray.Count(); i++)
        //    {
        //        sql += "\"";
        //        sql += data[i].ToString();
        //        sql += "\"";

        //        if (i < data.ItemArray.Count() - 1)
        //            sql += ", ";
        //    }
        //    sql += ")";
        //    ExecuteInsert(sql);

        //    int product_id;
        //    double quantity;
        //    double.TryParse(data[5].ToString(), out quantity);

        //    double amount, selling_price, item_cost, profit_margin;
        //    int.TryParse(data[1].ToString(), out product_id);
        //    double.TryParse(data[7].ToString(), out amount);
        //    double.TryParse(data[9].ToString(), out selling_price);
        //    double.TryParse(data[8].ToString(), out item_cost);
        //    double.TryParse(data[10].ToString(), out profit_margin);

        //    amount *= quantity;

        //    UpdateProductData(product_id, amount, selling_price, item_cost, profit_margin);
        //}


        // update product data
        //public void UpdateProductData(int product_id, double amount, double selling_price, double item_cost, double profit_margin)
        //{
        //    double product_quantity = 0;

        //    SQLiteCommand cmd = new SQLiteCommand(string.Format("select amount from store where product_id = {0}", product_id), connection);
        //    SQLiteDataReader reader = cmd.ExecuteReader();
        //    reader.Read();
        //    double.TryParse(reader.GetValue(0).ToString(), out product_quantity);
        //    reader.Close();

        //    product_quantity += amount;
        //    string sql = string.Format("UPDATE store SET amount={0} , selling_price={1} , purchasing_price={2} , profit_margin={3} WHERE product_id={4}", product_quantity, selling_price, item_cost, profit_margin, product_id);

        //    cmd.CommandText = sql;
        //    cmd.ExecuteNonQuery();
        //}



        //public int lastID(string category_name)
        //{
        //    int last_id = 0;
        //    string sql = string.Format("SELECT product_id FROM store WHERE category_name = \"{0}\" ORDER BY product_id", category_name);
        //    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
        //    SQLiteDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //        int.TryParse(reader.GetValue(0).ToString(), out last_id);
        //    return last_id;
        //}

        //public void addNewProduct(int category_id, string category_name, int product_id, string product_name, string unit, double amount, double selling_price, double purchasing_price)
        //{
        //    string sql = string.Format("INSERT INTO store " +
        //                 "( category_id , category_name , product_id , product_name , unit , amount, selling_price, purchasing_price) " +
        //                 "VALUES " +
        //                 "(\"{0}\" , \"{1}\" , \"{2}\" , \"{3}\" , \"{4}\", \"{5}\" ,\"{6}\",\"{6}\");",
        //                 category_id, category_name, product_id, product_name, unit, amount, selling_price, purchasing_price);
        //    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
        //    cmd.ExecuteNonQuery();
        //}


        // end of will be deleted



        // ----------------------------The End -------------------------------------//
    }
}