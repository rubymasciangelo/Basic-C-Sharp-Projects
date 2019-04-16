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
            const string prompt = "Please enter your";
            Console.WriteLine("Welcome! {0} name:", prompt);
            var inputName = Console.ReadLine();

            Console.WriteLine("{0} age:", prompt);
            var inputAge = Convert.ToInt32(Console.ReadLine());

            User user1 = new User();
            user1.Name = inputName;
            user1.Age = inputAge;

            Console.WriteLine("Your new code name is {0}{1}", user1.Name, user1.Age);
            Console.Read();

        }
    }
}
