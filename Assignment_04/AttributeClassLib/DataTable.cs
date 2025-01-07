namespace AttributeClassLib
{
    public class DataTable:Attribute
    {
        public string Table { get; set; }
    }

    public class DataColumn : Attribute
    {
        public string Columnname { get; set; }

        public bool KeyColumn { get; set; }

        public string ColumnType { get; set; }
    }

    public class Unmapped :Attribute
    {
        public bool unmapped { get; set; }
    }

    
}
