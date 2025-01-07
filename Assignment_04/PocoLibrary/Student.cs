using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributeClassLib;

namespace PocoLibrary
{
    [DataTable(Table = "Student")]

    public class Student
    {
        [DataColumn(Columnname = "RollNo", KeyColumn = true, ColumnType = "int ")]
        public int RollNo { get; set; }

        [DataColumn(Columnname = "S_Name", ColumnType = "varchar(50)")]
        public string Name { get; set; }

        [DataColumn(Columnname = "S_Address", ColumnType = "varchar(50)")]
        public string Address { get; set; }

        [DataColumn(Columnname = "S_Course", ColumnType = "varchar(50)")]
        public string  Course { get; set; }
    }
}
