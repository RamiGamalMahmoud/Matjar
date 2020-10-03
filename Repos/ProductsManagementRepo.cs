using DataAccessLayer;
using QueryBuilder;
using System;
using System.Data;

namespace Repos
{
    public class ProductsManagementRepo : IDisposable
    {
        private Connection conn;
        public ProductsManagementRepo()
        {
            this.conn = new Connection();
        }

        public void Dispose()
        {
            this.conn.Dispose();
        }

        public DataTable GetUnitsInfo(string productNameId)
        {
            using (Query query = new Query())
            {
                query.Select("info_id, base_unit_name, base_unit_id, sub_unit_name, sub_unit_id, sub_unit_count, sub_unit_is_purchaseable")
                    .From("units_info_view")
                    .Where("product_name_id", "=", productNameId);
                return this.conn.GetAll(query.QueryString, query.QueryParams);
            }
        }
    }
}
