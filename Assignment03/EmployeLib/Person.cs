using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeLib
{
   public class Person
    {


		private string  _Name;
		private bool _Gender;
		private Date _Birth;
		private string _Address;


		public Person() {

			_Name = " ";
			_Gender = true;
			_Birth = new Date();
			Address = " ";
		}

		public Person(string name, bool gender, Date birth, string address)
        {
            _Name = name;
            _Gender = gender;
            _Birth = birth;
            _Address = address;
        }


		public void Accept() {

            Console.WriteLine("Enter Name : ");
			_Name =Console.ReadLine();

            Console.WriteLine("Enter Gender (true for male & false for female)");
			_Gender=bool.Parse(Console.ReadLine());

			_Birth.AcceptDate();

            Console.WriteLine("Enter Address : ");
			_Address=Console.ReadLine();
		
		}

		public  int Age {

			get { 
			
			return Date.DiffrenceBetweenYears(_Birth,new Date(DateTime.Now.Day, DateTime.Now.Month,DateTime.Now.Year));

            }
        }

		public void Print() {
		
		Console.WriteLine("Name : "+_Name);
		Console.WriteLine($"Gender: {(_Gender ? "Male" : "Female")}");
		//Console.WriteLine("Gender : "+_Gender);
		Console.WriteLine("BirthDate : "+_Birth.ToString());
		Console.WriteLine("Age : " + Math.Abs(Age));
		Console.WriteLine("Address : "+_Address);
		
		}

        public override string ToString()
        {
            return "Name : "+_Name+ $"Gender: {(_Gender ? "Male" : "Female")}"+ " BirthDate : "+_Birth+" Age : "+Age+" Address : "+Address;
        }

        public Date Birth
		{
			get { return _Birth; }
			set { _Birth = value; }
		}


		public string Address
		{
			get { return _Address; }
			set { _Address = value; }
		}

		public bool Gender
		{
			get { return _Gender; }
			set { _Gender = value; }
		}

		public string  Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

	}
}
