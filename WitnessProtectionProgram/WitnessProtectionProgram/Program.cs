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
            
                while (newName > 5)
                {
                    switch (newName)
                    {
                        default:
                            Console.WriteLine("Whoa there, let's keep it between 0 and 5.");
                            Console.WriteLine("Try again:");
                            newName = Convert.ToInt16(Console.ReadLine());
                            break;
                    }
                }

            Console.WriteLine("Your new name is " + names[newName]);
            Console.Read();
               // int[] newAge = { 26, 37, 79, 6, 43, 15, 64 };
        }
    }
}
