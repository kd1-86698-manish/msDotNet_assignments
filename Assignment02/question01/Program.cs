using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.AcceptDetails();
            Console.WriteLine("------------------");
            Console.WriteLine("Student Details");
            Console.WriteLine("------------------");
            student.PrintDetails();
        }



        public struct Student
        {

            private string _Name;
            private bool _Gender;
            private int _Age;
            private int _Std;
            private char _Div;
            private double _Marks;


            #region Constructor

           

            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this._Name = name;
                this._Gender = gender;
                this._Age = age;
                this._Std = std;
                this._Div = div;
                this._Marks = marks;
            }


            #endregion


            #region Getter and Setter

            public double Marks
            {
                get { return _Marks; }
                set { _Marks = value; }
            }


            public char Div
            {
                get { return _Div; }
                set { _Div = value; }
            }


            public int Std
            {
                get { return _Std; }
                set { _Std = value; }
            }


            public int Age
            {
                get { return _Age; }
                set { _Age = value; }
            }


            public bool Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            #endregion

            #region Accept details

            public void AcceptDetails()
            {
                Console.WriteLine("Enter Name : ");
                 _Name = Console.ReadLine();

                Console.WriteLine("Enter Gender(True - Male & False - Female) : ");
                _Gender = bool.Parse(Console.ReadLine());

                Console.WriteLine("Enter Age : ");
                _Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Standard : ");
                _Std = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Division : ");
                _Div = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Marks : ");
                _Marks = Convert.ToDouble(Console.ReadLine());
            }
            #endregion

            #region Display Details
            public void PrintDetails()
            {
                Console.WriteLine("Name : " +Name);
                Console.WriteLine("Gender : " + Gender);
                Console.WriteLine("Age : " + Age);
                Console.WriteLine("Std : " + Std);
                Console.WriteLine("Div : " + Div);
                Console.WriteLine("Marks : " + Marks);
            }
            #endregion


        }
    }
}
