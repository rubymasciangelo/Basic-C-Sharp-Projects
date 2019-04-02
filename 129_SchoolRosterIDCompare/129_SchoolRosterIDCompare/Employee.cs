using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129_SchoolRosterIDCompare
{
    class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            employee1.Id.CompareTo(employee2.Id);
            return true | false;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            employee1.Id.CompareTo(employee2.Id);
            return true | false;
        }
    }
}
