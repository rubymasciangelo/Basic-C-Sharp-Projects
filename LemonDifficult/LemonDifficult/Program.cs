using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonDifficult
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 2;
            int decoyNum = 7;

            BaitSwitch.WaitWhat(inputNum, decoyNum);
            Console.ReadLine();
        }
    }
}
