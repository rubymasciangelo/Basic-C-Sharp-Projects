using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            string input1 = Console.ReadLine();

            BigStaticClass printResult = new BigStaticClass();
            printResult.HalfIt(input1);

            BigStaticClass hmmm = new BigStaticClass();
            hmmm.confuse(out input1);

            Console.ReadKey();
        }

        //example sort of
        //{
        //    int a;
        //    int b;
        //    Program p = new Program();
        //    p.DoSomething(out a, out b);
        //}
        //public void DoSomething(out int x, out int y)
        //{
        //    x = 5;
        //    y = 20;
        //}
    }
}
