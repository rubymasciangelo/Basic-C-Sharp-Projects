using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            int input1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You totally don't have to but you may add a second number: ");
            string input2 = Console.ReadLine();

            if (input2 != "") //this works but I feel like it defeats the purpose of an opptional parameter?
            {
                int input2live = Convert.ToInt16(input2);
                Okurrr.SomeMath(input1, input2live);
            }
            else  //doing this ifelse prevents an error being thrown for converting a null string value for input2 to int
            {
                Okurrr.SomeMath(input1);
            }

            Console.ReadKey();
        }

        //old overloading added
        //{
        //    Console.WriteLine("Please input an integer: ");
        //    string input1 = Console.ReadLine();
        //    Console.WriteLine("You totally don't have to but you may add a second number: ");
        //    string input2 = Console.ReadLine();
        //    if (input2 != "")
        //    {
        //        Okurrr answer = new Okurrr();
        //        answer.SomeMath(input1, input2);
        //    }
        //    else
        //    {
        //        Okurrr answer = new Okurrr();
        //        answer.SomeMath(input1);
        //    }

        //    Console.ReadKey();
        //}
    }
}
