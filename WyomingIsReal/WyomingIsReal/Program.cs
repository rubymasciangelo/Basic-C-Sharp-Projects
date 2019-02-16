using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyomingIsReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a lie:");
            string lie = Console.ReadLine();
            bool bigLie = lie == "Wyoming is real";

            do
            {
                switch (lie)
                {
                    case "Wyoming is real":
                        Console.WriteLine("You know too much. Run.");
                        bigLie = true;
                        break;
                    default:
                        Console.WriteLine("Go bigger. Tell me a bigger lie.");
                        break;
                }
            }
            while (!bigLie);

            Console.WriteLine("Name an American state");

        }
    }
}
