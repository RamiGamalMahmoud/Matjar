using DataAccessLayer;
using System;

namespace Repos
{
    public class ProductsRepo : IDisposable
    {
        private Connection conn;
        public ProductsRepo()
        {
            this.conn = new Connection();
        }
        public void Dispose()
        {
            this.conn.Dispose();
        }
    }
}
