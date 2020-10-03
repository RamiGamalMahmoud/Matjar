using DataAccessLayer;
using System;
using QueryBuilder;
using System.Data;

namespace Repos
{
    public class CategoriesRepo : IDisposable
    {
        private Connection conn;

        public CategoriesRepo()
        {
            this.conn = new Connection();
        }

        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable GetCategories()
        {
            using (Query query = new Query())
            {
                query.Select("id, category ")
                  .From("categories");
                return this.conn.GetAll(query.QueryString);
            }
        }
    }
}
