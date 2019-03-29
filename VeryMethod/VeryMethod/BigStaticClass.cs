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
        public static string Confuse(out string notsure)
        {
            notsure = "why tho";
            return notsure;
        }

        public static string Overload(string uabird)
        { 
            uabird = "Ok great";
            return uabird;
        }
        public static string Overload(string uabird, string useebird)
        {
            useebird = "Be careful";
            return useebird;
        }

    }
}
