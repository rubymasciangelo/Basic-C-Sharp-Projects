using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_SchoolRosterGenerics
{
    class Employee<T> : Person
    {
        public List<T> things { get; set; }

     
    public void Print() //method to print all variable type items 'thing' in generic list 'things'
        {
            foreach (var thing in things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
