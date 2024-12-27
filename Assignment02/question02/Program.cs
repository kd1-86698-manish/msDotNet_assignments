using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace question02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] arr = new Student[10];
            Student.CreateArray(ref arr); 
            Student.AcceptInfo(ref arr);
            Console.WriteLine("Student List");
            Console.WriteLine("-----------------------");
            Student.PrintInfo(ref arr);
            Console.WriteLine("Reverse Student List");
            Console.WriteLine("-----------------------");
            Student.ReverseArray(ref arr);

        }



        public class Student
        {

            private string _Name;
            private bool _Gender;
            private int _Age;
            private int _Std;
            private char _Div;
            private double _Marks;


            #region Constructor
            public Student()
            {
                Name = string.Empty;
                Gender = false;
                Age= 0;
                Std = 0;
                Div ='A' ;
                Marks = 0.0;
            }


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
                Console.WriteLine("----------------");


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
                Console.WriteLine("----------------------");
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Gender : " + Gender);
                Console.WriteLine("Age : " + Age);
                Console.WriteLine("Std : " + Std);
                Console.WriteLine("Div : " + Div);
                Console.WriteLine("Marks : " + Marks);
            }
            #endregion


            public static void CreateArray(ref Student[] arr ) 
            {
                Console.WriteLine("Enter No Of Students : ");
                int n =Convert.ToInt32(Console.ReadLine());
                arr = new Student[n];  
            }

            public static void AcceptInfo(ref Student[] arr)
            {
                for (int i = 0; i < arr.Length; i++) { 
                
                    Student student=new Student();

                    student.AcceptDetails();
                    arr[i] = student;
                }
                
            }


            public static void PrintInfo(ref Student[] arr)
            {
                for (int i = 0; i < arr.Length; i++) 
                {
                    arr[i].PrintDetails();
                        
                }

            }
            public static void ReverseArray(ref Student[] arr) {
                int n = arr.Length;

                Student[] newarr = new Student[n];

                for (int i = 0; i < n; i++)
                {

                    newarr[n - 1 - i] = arr[i];
                }
                PrintInfo(ref newarr);
            
            }

        }
    }
}
