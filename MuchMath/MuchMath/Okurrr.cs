using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchMath
{
    public class Okurrr
    {
        public void SomeMath(string input1, string input2)
        {
            int dub =  Convert.ToInt16(input1) + Convert.ToInt16(input2) + 3;
            Console.WriteLine(dub);
            //return dub;
        }
        public void SomeMath(string input1)
        {
            int single = Convert.ToInt16(input1) + 3;
            Console.WriteLine(single);
            //return single;
        }
    }
}
