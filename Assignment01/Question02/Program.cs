using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basic Calculator");

            int res;

            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operator : ");
            String op = Console.ReadLine();



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
                    break;
            }
        }
    }
}
