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
            //Employee employee2 = new Employee();
            //employee2.FirstName = "Sample";
            //employee2.LastName = "Quit";

            IQuittable displayQuitMessage = new Employee();
            displayQuitMessage.Quit();//employee2);
            Console.ReadKey();

            IQuittable displayDropOutMessage = new Student();
            displayDropOutMessage.Quit();
            Console.ReadKey();

            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Employee";

            employee1.SayName();
            Console.ReadKey();
            employee1.Quit();
            Console.ReadKey();
        }
    }
}
