using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeLib
{
    public class Supervisor:Employee
    {

		private int _Subbordinates;


        public Supervisor():base()
        {
            _Subbordinates = 0;
            Designation = "Supervisor";
            
        }
        public Supervisor(string name, bool gender, Date birth, string address, double salary, Department dept, int subbordinates)
             : base(name, gender, birth, address, salary, dept) 
        {
            this.Subbordinates = subbordinates;
            Designation = "Supervisor";
        }


        public new void Accept()
        {
            base.Accept();

            Console.WriteLine("Enter No Of Subordinates : ");
            Subbordinates = Convert.ToInt32(Console.ReadLine());
        
        
        }



        public new void Print()
        {

            base.Print();
            Console.WriteLine("Subordinates : " + Subbordinates);
        }

        public override string ToString()
        {
            return base.ToString() + " SubOrdinates : " + Subbordinates;
        }



        public int Subbordinates
        {
			get { return _Subbordinates; }
			set { _Subbordinates = value; }
		}

	}
}
