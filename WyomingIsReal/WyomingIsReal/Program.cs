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
                        Console.WriteLine("No, go bigger.");
                        Console.WriteLine("Tell me a bigger lie:");
                        lie = Console.ReadLine();
                        break;
                }
            }
            while (!bigLie);

            Console.WriteLine("Name an American state");
            string state = Console.ReadLine();
            bool america = state != "Wyoming";

            while (true)
            {
                switch (state)
                {
                    case "Florida":
                        Console.WriteLine("Is Florida a part of America, though? Or is America... part of Florida...");
                        Console.WriteLine("Tell me another American state:");
                        state = Console.ReadLine();
                        break;
                    case "Wyoming":
                        Console.WriteLine("Ha! The truth is out there and it's life-changing.");
                        Console.WriteLine("Tell me an actual American state though:");
                        state = Console.ReadLine();
                        break;
                    case "Iowa":
                        Console.WriteLine("Perhaps, but Does It Spark Joy?");
                        Console.WriteLine("Tell me another American state:");
                        state = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Seems real! Tell me another American state:");
                        state = Console.ReadLine();
                        break;
                }
            }

            Console.Read();
        }
    }
}
