using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeLib
{
    public class Manager : Employee
    {
		private double _Bonus;
        public Manager():base()
        {
            this.Bonus = 0.0;
            Designation = "Manager";
        }

        public Manager(string name, bool gender, Date birth, string address, double salary, Department dept, double bonus)
             : base(name, gender, birth, address,salary, dept)
        {
           this.Bonus = bonus;
            Designation = "Manager";
        }


        public new void Accept() 
        { 
        base.Accept();

            Console.WriteLine("Enter Bonus : ");
            _Bonus=Convert.ToDouble(Console.ReadLine());
        }

        public new void Print() 
        {
        
            base.Print();
            Console.WriteLine("Bonus : "+_Bonus);
        }

        public override string ToString()
        {
            return base.ToString()+" Bonus : "+_Bonus;
        }


        public double Bonus
		{
			get { return _Bonus; }
			set { _Bonus = value; }
		}

	}
}
