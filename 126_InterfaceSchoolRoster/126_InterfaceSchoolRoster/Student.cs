using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _126_InterfaceSchoolRoster
{
    class Student : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Student name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has dropped out.");
        }
    }
}
