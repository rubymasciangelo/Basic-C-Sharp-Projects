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

            bool comparison = employee1 == employee2; //compares IDs of employees
            Console.WriteLine(comparison);
            Console.Read();

        }

    }
}
