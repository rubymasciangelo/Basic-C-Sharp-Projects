using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _165_AgeExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt16(Console.ReadLine());
                
                if (age < 1) //throws specific exception if age is 0 or negative
                {
                    throw new ArgumentOutOfRangeException();
                }

                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine("You were born in {0}", birthYear);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ages 0 or younger are unacceptable.");
                Console.Read();
                return;
            }
            catch(Exception)
            {
                Console.WriteLine("You've done something wrong...");
                Console.Read();
                return;
            }

            Console.Read();
        }
    }
}
