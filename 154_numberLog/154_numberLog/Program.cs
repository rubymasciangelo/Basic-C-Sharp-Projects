using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _154_numberLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Desktop\Basic_CS_Projects\Basic-C-Sharp-Projects\154_numberLog\log.txt", input);
        }//writes user input as a string to the log.txt
    }
}
