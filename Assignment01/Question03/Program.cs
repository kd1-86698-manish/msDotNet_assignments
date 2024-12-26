using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Calculator");
            string value;
            do

            {
                int res;

                Console.WriteLine("Enter First Number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------");
                Console.WriteLine("Addition : + ");
                Console.WriteLine("Subtraction : - ");
                Console.WriteLine("Multiplication : * ");
                Console.WriteLine("Division : / ");
                Console.WriteLine("---------------------");


                Console.WriteLine("Enter Operator : ");
                String op = Console.ReadLine();
                Console.WriteLine("-------------------------------");

                switch (op)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition = " + res);
                        break;

                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction = " + res);
                        break;

                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication = " + res);
                        break;

                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division = " + res);
                        break;


                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Do You Want to continue (y/n) ");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
            Console.WriteLine("Thank You");

        }
    }
}
