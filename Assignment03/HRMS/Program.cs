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
        
            //Person person = new Person();
            //person.Accept();
            //person.Print();

            //Employee emp =new Employee();
            //emp.Accept();
            //emp.Print();

            Manager manager = new Manager();
            manager.Accept();
            Console.WriteLine(manager.ToString()); ;
            //manager.Print();

        }
    }
}
