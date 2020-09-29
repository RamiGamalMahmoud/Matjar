namespace DataAccessLayer
{
    public enum Operator { NOT_EQUAL, EQUAL, GRATER = 4, LESS = 6, GRATER_OR_EQUAL = 5, LESS_OR_EQUAL = 7 }
    public class QueryBuilder
    {
        private string Query { get; set; }
        private string MasterTable { get; set; }

        public QueryBuilder Select(params string[] columns)
        {
            Query = "SELECT  ";
            for (int i = 0; i < columns.Length; i++)
            {
                Query += i > 0 ? "\t" : "";
                Query += columns[i];
                if (i != columns.Length - 1)
                {
                    Query += ", \n";
                }
            }

            Query += " \n";
            return this;
        }

        public QueryBuilder From(string table_name)
        {
            MasterTable = table_name;
            Query += " FROM ";
            Query += table_name;
            return this;
        }


        public QueryBuilder Join(string table_to_join, object first_table_key, object second_table_key)
        {
            Query += string.Format(" JOIN {0} ON {1} = {2} \n", table_to_join, first_table_key, second_table_key);
            return this;
        }
        public QueryBuilder InsertInto()
        {
            return this;
        }

        public QueryBuilder Where(string column_name, Operator op, object value)
        {
            Query += string.Format(" WHERE {0} {1} {2}", column_name, GetOperator(op), value);
            return this;
        }

        private string GetOperator(Operator op)
        {
            switch (op)
            {
                case Operator.EQUAL:
                    return "=";
                case Operator.GRATER:
                    return ">";
                case Operator.NOT_EQUAL:
                    return "!=";
                case Operator.GRATER_OR_EQUAL: 
                    return ">=";
                case Operator.LESS:
                    return "<";
                case Operator.LESS_OR_EQUAL:
                    return "<=";
                default: return "";
            }
        }
        public override string ToString()
        {
            return Query;
        }
    }
}
