using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class QueriesStrings
    {
        /// <summary>
        /// Return string query for catgories table
        /// </summary>
        /// <returns></returns>
        public static string CategoriesQuery() => "SELECT id, category FROM categories";
        public static string UnitsQuery() => "SELECT id, unit FROM units ORDER BY unit";
        public static string YearsQuery() => "SELECT DISTINCT  year FROM purchases_monthes";
        public static string MonthesForYear(object year_id) => string.Format("SELECT monthes FROM purchases_monthes WHERE year = {0} ORDER BY monthes DESC", year_id);
        public static string CategoryProductsQuery(object category_id) => string.Format("SELECT product_name_id, product_name FROM products_names WHERE category_id = {0} ORDER BY product_name", category_id);
        public static string ProductsForCategoryQuery(object category_id) => string.Format("SELECT * FROM products_data_view WHERE category_id = {0} ORDER BY product_name", category_id);
        public static string ProductID(object product_name_id, object unit_id) => string.Format(@"SELECT product_id FROM products WHERE product_name_id = {0} AND unit_id = {1}", product_name_id, unit_id);

        public static string BaseUnitQuery(object product_name_id) => string.Format(@"
            SELECT units.id AS unit_id, 
                   units.unit AS unit_name
              FROM products_units_info
                   JOIN units ON products_units_info.base_unit_id = units.id 
            WHERE products_units_info.product_name_id = {0}
            ORDER BY unit_name ;",
            product_name_id);

        public static string SubUnitQuery(object product_name_id) => string.Format(@"
            SELECT units.id AS unit_id, 
                   units.unit AS unit_name
              FROM products_units_info
                   JOIN units ON products_units_info.sub_unit_id = units.id 
            WHERE products_units_info.product_name_id = {0}
              AND products_units_info.sub_unit_is_purchaseable = 'نعم'
            ORDER BY unit_name ;",
            product_name_id);

        public static string PurchasesQuery(object year, object month) => string.Format("SELECT * FROM purchases_view WHERE purchases_view.purchase_date LIKE '{0}/{1}/__' ", year, month);
        public static string ProductNameDataQuery(object product_name_id ) => string.Format(@"
            SELECT products.product_id,
                    units.unit,
                    products.amount,
                    products.purchasing_price,
                    products.selling_price,
                    products.profit_margin
            FROM products
            JOIN units ON products.unit_id = units.id
            WHERE products.product_name_id = {0}
            ORDER BY products.purchasing_price DESC,
            products.selling_price DESC",
            product_name_id);

        public static string UnitsInfoQuery (object product_name_id ) => string.Format(@"
            SELECT  products_units_info.info_id,
                    base_units.unit AS base_unit_name,
                    base_units.id AS base_unit_id,
                    sub_units.unit AS sub_unit_name,
                    sub_units.id AS sub_unit_id,
                    products_units_info.sub_unit_count,
                    products_units_info.sub_unit_is_purchaseable
            FROM products_units_info
            JOIN
                units base_units ON products_units_info.base_unit_id = base_units.id
            JOIN
                units sub_units ON products_units_info.sub_unit_id = sub_units.id
            JOIN
                products_names ON products_units_info.product_name_id = products_names.product_name_id
            WHERE products_names.product_name_id = {0}
            ORDER BY products_units_info.sub_unit_count ASC",
            product_name_id);
    }
}
