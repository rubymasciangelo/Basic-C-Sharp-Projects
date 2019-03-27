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
            int result = Convert.ToInt16(input1) / 2;
            Console.WriteLine();
        }
        public static void Minus2(out int notsure)
        {
            notsure = 4;
        }


    }
}
