using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryMethod
{
    public class BigStaticClass
    {
        public void HalfIt(string input1)
        {
            double result = Convert.ToDouble(input1) / 2;
            Console.WriteLine(result);
        }
        public void confuse(out string notsure)
        {
            notsure = "why tho";
            Console.WriteLine(notsure);
        }

        public static void overload(string inputHappy)
        {
            Console.WriteLine("Ok great");
        }
        public static void overload(string inputHappy, string inputBird)
        {
            Console.WriteLine("Be careful");
        }

    }
}
