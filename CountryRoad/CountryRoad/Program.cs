using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder bestSong = new StringBuilder();

            bestSong.Append("Country Road");
            bestSong.Append("Take me home");
            bestSong.Append("To the place");
            bestSong.Append("I belong");

            Console.WriteLine(bestSong);
            Console.Read();
        }
    }
}
