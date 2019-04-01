using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _126_InterfaceSchoolRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable person = new Employee();

            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";

            employee1.SayName();
            Console.ReadKey();
            employee1.Quit();
            Console.ReadKey();
        }
    }
}
