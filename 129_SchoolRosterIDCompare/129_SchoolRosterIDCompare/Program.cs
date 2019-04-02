using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_SchoolRosterIDCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Employee";
            employee1.Id = 11111;

            Employee employee2 = new Employee();
            employee2.FirstName = "Sample2";
            employee2.LastName = "Employee2";
            employee2.Id = 22222;

            //These all work but they also work if I comment out the operator overloads??

            //if (employee1.Id == employee2.Id)
            //{
            //    Console.WriteLine("Employee ID numbers are the same");
            //}
            //else
            //{
            //    Console.WriteLine("Employee ID numbers do not match");
            //}
            //Console.ReadKey();


            //Console.WriteLine((employee1.Id == employee2.Id).ToString());
            //Console.ReadKey();

            //Console.WriteLine(employee1.Id == employee2.Id);
            //Console.ReadKey();


        }

    }
}
