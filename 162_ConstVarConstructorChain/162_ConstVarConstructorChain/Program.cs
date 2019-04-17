using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_ConstVarConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string hiFrance = "Bonjour"; //const french greeting message
            Console.WriteLine(hiFrance);

            var user1 = new User("Salma Hyek", 911); //initializing constructor with a var
            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.Phone);
            Console.Read();

        }
    }
}
