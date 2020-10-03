using DataAccessLayer;
using System;
using QueryBuilder;
using System.Data;
using System.Collections.Generic;

namespace Repos
{
    public class UnitsRepo : IDisposable
    {
        private Connection conn;

        public UnitsRepo()
        {
            this.conn = new Connection();
        }

        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable GetUnits()
        {
            using (Query query = new Query())
            {
                query.Select("id, unit")
                    .From("units")
                    .OrderBy("unit", SordOrder.ASC);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }
    }
}
