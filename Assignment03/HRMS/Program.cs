using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeLib;

namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Employee emp = new Employee();
            emp.Accept();
            Console.WriteLine("----------------------------");
            //emp.Print();
            emp.ToString();
            Console.WriteLine("----------------------------");

            
            Manager manager = new Manager();
            manager.Accept();
            Console.WriteLine("----------------------------");
            //manager.Print();
            manager.ToString();
            Console.WriteLine("----------------------------");
            

            Supervisor supervisor = new Supervisor();
            supervisor.Accept();
            Console.WriteLine("----------------------------");
            //supervisor.Print();
            supervisor.ToString();
            Console.WriteLine("----------------------------");
           

            WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();
            Console.WriteLine("----------------------------");
            //wageEmp.Print();
            wageEmp.ToString();
            Console.WriteLine("----------------------------");

        }
    }
}
