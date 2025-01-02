using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MathsLib;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assembly assembly = Assembly.LoadFrom("D:\\DAC\\DAC_Assignment\\msDotNet_assignments\\Assignment04\\MathsLib\\bin\\Debug\\MathsLib.dll");

            Type type = assembly.GetType("MathsLib.Maths");

            object obj = Activator.CreateInstance(type);

            Maths maths = new Maths();
            int num1;
            int num2;
            int res;

            while (true)
            {

                Console.WriteLine("-----------------");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("-----------------");

                Console.WriteLine("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                    break;

                MethodInfo methodInfo = null;
                object[] parameters = null;


                switch (choice)
                {
       
                    case 1:
                        {
                            methodInfo = type.GetMethod("Add");
                            parameters = new object[] { GetOperand("Enter Number 1 : "), GetOperand("Enter Number 2 :") };


                          }
                        break;

                    case 2:
                        {

                            methodInfo = type.GetMethod("Sub");
                            parameters = new object[] { GetOperand("Enter Number 1 :"), GetOperand("Enter Number 2 :") };

                        }
                        break;

                    case 3:
                        {
                            methodInfo = type.GetMethod("Mul");
                            parameters = new object[] { GetOperand("Enter Number 1 :"), GetOperand("Enter Number 2 :") };

                        }
                        break;

                    case 4:
                        {
                            methodInfo = type.GetMethod("Div");
                            parameters = new object[] { GetOperand("Enter Number 1 :"), GetOperand("Enter Number 2 :") };
                        }
                        break;


                    default:
                        Console.WriteLine("Wrong Choice..!");
                        continue;
                }


                Console.WriteLine("-----------------");
                    var result = methodInfo.Invoke(obj, parameters);
                    Console.WriteLine("Result : "+ result);
                
            }
        }


        static int GetOperand(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
    }
}
