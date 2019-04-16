using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_ConstVarChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string prompt = "Please write your";
            Console.WriteLine("Welcome! {0} name:", prompt);
            User name = new User(Console.ReadLine());

            Console.WriteLine("{0} phone number:", prompt);
            User phone = new User(Console.ReadLine());

            var userInfo = new List<User>();

            Console.WriteLine(userInfo);
            Console.Read();
        }
    }
}
