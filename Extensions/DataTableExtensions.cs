using System.Collections.Generic;
using System.Data;

namespace Extensions
{
    public static class DataTableExtensions
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
}
