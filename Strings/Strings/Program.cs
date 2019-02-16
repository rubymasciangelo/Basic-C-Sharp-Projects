using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";
            string quote = "The man said, \\Henlo\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = @"C:\\Users\\Jesse";

            bool tOrF = name.Contains("s");
            tOrF = name.EndsWith("s");

            int length = name.Length;

            name = name.ToUpper();


        }
    }
}
