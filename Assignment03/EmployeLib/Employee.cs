using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeLib
{

	public enum Department { HR, IT, Sales, Marketing, Finance }

    public class Employee : Person
    {

		public static int Counter = 0;
		
	
		private int _Id; //autogemrated Id
		private double _Salary;
		private string _Designation;
		private Department _DepartType; //enum



		public Department DepartType
		{
			get { return _DepartType; }
			set { _DepartType = value; }
		}

       
        public Employee():base()
        {
			_Id = ++Counter;
			_Designation = "Employee";
			_Salary = 0.0;
			_DepartType = Department.IT;
        }


        public Employee(string name, bool gender, Date birth, string address,double salary, Department dept) 
			:base( name,gender,birth,address)
        {

			_Id= ++Counter;
			_Salary=salary;
			_Designation = "Employee";
			_DepartType = dept;

        }


		public void Accept() 
		{
			base.Accept();

			Console.WriteLine("Enter Salary : ");
			_Salary=Convert.ToDouble(Console.ReadLine());

         

            Console.WriteLine("Enter DepartMent (HR, IT, Sales, Marketing, Finance) : ");
			_DepartType=(Department) Enum.Parse(typeof(Department),Console.ReadLine());	//explicit typecasting required
		
		
		}

		public new void Print() { 
		
            Console.WriteLine("Id : "+_Id);
			base.Print();
            Console.WriteLine("Salary : "+_Salary);
            Console.WriteLine("Designation : "+_Designation);
            Console.WriteLine("Department : "+ _DepartType);

		}


        public override string ToString()
        {
            return base.ToString()+" Id : "+_Id+" Salary : "+_Salary+" Designation : "+_Designation+" Department : "+_DepartType;
        }

        public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

		public double Salary
		{
			get { return _Salary; }
			set { _Salary = value; }
		}


		public string Designation
		{
			get { return _Designation; }
			set { _Designation = value; }
		}

	}
}
