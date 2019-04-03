using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_SchoolRosterGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stringList = new Employee<string>();
            stringList.things = new List<string> { "teacher", "custodian", "bus driver", "counselor"};

            Employee<int> intList = new Employee<int>();
            intList.things = new List<int> { 1, 2, 3, 4 };


            stringList.Print();
            intList.Print(); //calling stringList ans intList to print all items to console


            Console.ReadKey();
        }
    }
}
