using AttributeClassLib;

namespace PocoLibrary
{
    [DataTable(Table = "Employee")]
    public class Employee
    {
        [DataColumn(Columnname = "empNo", KeyColumn = true, ColumnType = "int ")]
        public int empNo { get; set; }

        [DataColumn(Columnname = "empName", ColumnType = "varchar(50)")]
        public string name { get; set; }

        [DataColumn(Columnname = "empAddress", ColumnType = "varchar(50)")]
        public string address { get; set; }

        [DataColumn(Columnname = "empSalary", ColumnType = "bigint")]
        public double salary { get; set; }

        [DataColumn(Columnname = "empAnnualSalary", ColumnType = "bigint")]
        public double annualSalary { get; set; }


        [DataColumn(Columnname = "empDesignation", ColumnType = "varchar(50)")]
        public string designation { get; set; }



    }
}
