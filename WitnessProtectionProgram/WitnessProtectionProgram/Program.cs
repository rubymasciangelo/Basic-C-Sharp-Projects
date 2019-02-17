using System;
using System.Collections.Generic;


namespace WitnessProtectionProgram
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Lamb Jaqueline", "Kyle Canada", "Miranda Lambert", "Brick Waterburg", "Lemon Carlisle", "Pepsi" };

            Console.WriteLine("Welcome to the Witness Protection Program! Time to generate a new identity!");
            Console.WriteLine("Pick a number between 0 and 5:");
            int newName = Convert.ToInt16(Console.ReadLine());

            if (newName > 5)
            {
                Console.WriteLine("Whoa there, let's keep it between 0 and 5.");
                Console.WriteLine("Try again:");
            }

            else
            {
                Console.WriteLine("Your new name is names[newname]");
            }

            Console.Read();
               // int[] newAge = { 26, 37, 79, 6, 43, 15, 64 };
        }
    }
}
