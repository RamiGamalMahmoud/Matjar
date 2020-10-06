using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DataAccessLayer
{
    public class Connection : IDisposable
    {
        private readonly SQLiteConnection conn;
        public Connection()
        {
            this.conn = new SQLiteConnection(this.LoadConnectionString("MatjarDatabase"));
            this.conn.Open();
        }

        public void Dispose()
        {
            this.conn.Close();
        }

        /// <summary>
        /// Get one row from database
        /// </summary>
        /// <returns>DataRow</returns>
        public DataRow Get(string sql, List<SqlParameter> param = null)
        {
            DataTable table = new DataTable();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, this.conn))
            {
                if (param != null) cmd.Parameters.AddRange(this.SqlToSQLiteParameters(param));
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            if (table.Rows.Count == 0)
            {
                return null;
            }
            return table.Rows[0];
        }

        /// <summary>
        /// Get all rows from database for the suplied statement and params
        /// </summary>
        public DataTable GetAll(string sql, List<SqlParameter> param = null)
        {
            DataTable table = new DataTable();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, this.conn))
            {
                if (param != null) cmd.Parameters.AddRange(this.SqlToSQLiteParameters(param));
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    try
                    {
                        adapter.Fill(table);
                    }
                    catch(SQLiteException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(sql);
                    }
                }
            }

            return table;
        }

        /// <summary>
        /// Run sql statement that is none query like [UPDATE, INSERT, DELETE]
        /// </summary>
        /// <returns>Void</returns>
        public int Run(string sql, List<SqlParameter> param)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, this.conn))
            {
                cmd.Parameters.AddRange(this.SqlToSQLiteParameters(param));
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch(SQLiteException ex)
                {
                    Console.WriteLine(ex.Message + " : " + param[0].Value);
                    return 0;
                }
                //return cmd.ExecuteNonQuery();
            }
        }

        public bool IsExists(string sql, List<SqlParameter> param)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, this.conn))
            {
                cmd.Parameters.AddRange(this.SqlToSQLiteParameters(param));
                return cmd.ExecuteScalar() != null;
            }
        }

        private SQLiteParameter[] SqlToSQLiteParameters(List<SqlParameter> param)
        {
            var output = new List<SQLiteParameter>();
            foreach (SqlParameter p in param)
            {
                output.Add(new SQLiteParameter(p.ParameterName, p.Value));
            }
            return output.ToArray();
        }
        private string LoadConnectionString(string connection_string)
        {
            return ConfigurationManager.ConnectionStrings[connection_string].ConnectionString;
        }
    }
}
