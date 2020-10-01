using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace QueryBuilder
{
    public enum SordOrder { DESC, ASC }
    public class Query
    {
        private string queryString = "";

        private List<SqlParameter> queryParams = new List<SqlParameter>();
        public string QueryString
        {
            get
            {
                return this.queryString;
            }
            private set
            {
                this.queryString = value;
            }
        }

        public List<SqlParameter> QueryParams
        {
            get
            {
                return this.queryParams;
            }
        }

        public Query Select(string columns)
        {
            this.QueryString = $"SELECT {columns} ";
            return this;
        }

        public Query Delete()
        {
            this.QueryString = "DELETE ";
            return this;
        }

        public Query InsertInto(string tableName)
        {
            this.QueryString = $"INSERT OR IGNORE  INTO {tableName} ";
            return this;
        }

        public Query Values(string[] columns, string[] values)
        {
            if (columns.Length != values.Length)
            {
                throw new Exception("columns count not equal values count");
            }
            this.QueryString += "VALUES (";

            for (int i = 0; i < values.Length; i++)
            {
                string key = "@" + columns[i];
                this.QueryString += key;
                this.QueryParams.Add(new SqlParameter(key, values[i]));
                if (i < values.Length - 1)
                {
                    this.QueryString += ", ";
                }
            }

            this.QueryString += ")";
            return this;
        }

        public Query Update(string table)
        {
            this.QueryString = $"UPDATE {table} ";
            return this;
        }

        public Query SetValues(string[] columns, string[] values)
        {
            if (columns.Length != values.Length)
            {
                throw new Exception("columns count not equal values count");
            }
            this.QueryString += "SET ";
            for (int i = 0; i < columns.Length; i++)
            {
                string key = "@" + columns[i];
                this.QueryString += $"{columns[i]}={key}";
                this.QueryParams.Add(new SqlParameter(key, values[i]));
                if (i < values.Length - 1)
                {
                    this.QueryString += ", ";
                }
            }
            this.QueryString += " ";
            return this;
        }

        public Query From(string tableName)
        {
            this.QueryString += $"FROM {tableName} ";
            return this;
        }

        public Query Where(string column, string op, string criteria)
        {
            string key;
            if (column.Contains("."))
            {
                string[] arr = column.Split('.');
                key = $"@{arr[1]}";
            }
            else
            {
                key = $"@{column}";
            }
            this.QueryString += $"WHERE {column} {op} {key} ";
            this.QueryParams.Add(new SqlParameter(key, criteria));
            return this;
        }

        public Query AndWhere(string column, string op, string criteria)
        {
            string key;
            if (column.Contains("."))
            {
                string[] arr = column.Split('.');
                key = $"@{arr[1]}";
            }
            else
            {
                key = $"@{column}";
            }
            this.QueryString += $"AND {column} {op} {key} ";
            this.QueryParams.Add(new SqlParameter(key, criteria));
            return this;
        }

        public Query OrWhere(string column, string op, string criteria)
        {
            string key;
            if (column.Contains("."))
            {
                string[] arr = column.Split('.');
                key = $"@{arr[1]}";
            }
            else
            {
                key = $"@{column}";
            }
            this.QueryString += $"OR {column} {op} {key} ";
            this.QueryParams.Add(new SqlParameter(key, criteria));
            return this;
        }

        public Query OrderBy(string column, SordOrder order = SordOrder.ASC)
        {
            this.QueryString += $"ORDER BY {column} {order}";
            return this;
        }

        public Query Join(string otherTable)
        {
            return this.MakeJoin("JOIN", otherTable);
        }

        public Query LeftJoin(string otherTable)
        {
            return this.MakeJoin("LEFT JOIN", otherTable);
        }

        public Query RightJoin(string otherTable)
        {
            return this.MakeJoin("RIGHT JOIN", otherTable);
        }

        public Query On(string leftColumn, string rightColumn)
        {
            this.QueryString += $"ON {leftColumn} = {rightColumn} ";
            return this;
        }

        public Query Clear()
        {
            this.QueryString = "";
            this.QueryParams.Clear();
            return this;
        }

        private Query MakeJoin(string type, string leftTable)
        {
            this.QueryString += $"{type} {leftTable} ";
            return this;
        }

        /**
         * SELECT FROM
         * DELETE FROM
         * UPDATE 'table' SET column=value WHERE col=criteria
         * INSERT INTO 'table' (col1, col2, ..., colN) VALUES ();
         */
    }
}
