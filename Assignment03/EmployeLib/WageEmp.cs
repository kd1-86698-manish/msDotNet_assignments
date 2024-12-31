using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeLib
{
    public class WageEmp : Employee
    {
		private int _Hours;
		private int _Rate;


        public WageEmp():base()
        {
			Hours = 0;
			Rate = 0;
			Designation = "Wage";
            
        }

        public WageEmp(string name, bool gender, Date birth, string address, double salary, Department dept, int hours,int rate)
             : base(name, gender, birth, address, salary, dept)
        {
            Hours=hours;
			Rate=rate;
            Designation = "Wage";
        }

        public new void Accept()
        {
            base.Accept();

            Console.WriteLine("Enter Hours : ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate : ");
            Rate = Convert.ToInt32(Console.ReadLine());


        }



        public new void Print()
        {

            base.Print();
            Console.WriteLine("Hours : " + Hours);
            Console.WriteLine("Rate : "+Rate);
        }

        public override string ToString()
        {
            return base.ToString() + " Hours : " + Hours+" hrs"+" Rate : "+Rate+" Rs.";
        }



        public int Rate
		{
			get { return _Rate; }
			set { _Rate = value; }
		}


		public int Hours
		{
			get { return _Hours; }
			set { _Hours = value; }
		}


	}
}
