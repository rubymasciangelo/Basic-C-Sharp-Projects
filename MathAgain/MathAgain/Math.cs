using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAgain
{
    public class Math
    {
        public static int DoMath(int inputX)
        {
            int plus2 = inputX + 2;
            return plus2;
        }
        public static int DoMath(Decimal decimalX)
        {
            decimal plus4 = decimalX + 4;
            return Convert.ToInt16(plus4);
        }

    }
}
