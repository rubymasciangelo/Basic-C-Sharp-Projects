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
            Console.ReadLine();

               int[] ages = { 26, 37, 79, 6, 43, 15, 64 };

            Console.WriteLine("Pick a number between 0 and 6:");
            int newAge = Convert.ToInt16(Console.ReadLine());

            while (newAge > 6)
            {
                switch (newAge)
                {
                    default:
                        Console.WriteLine("Whoa there, let's keep it between 0 and 6.");
                        Console.WriteLine("Try again:");
                        newAge = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Your new age is " + ages[newAge] + " years old.");
            Console.ReadLine();

            List<string> spiceGirls = new List<string>();
            spiceGirls.Add("Ginger Spice");
            spiceGirls.Add("Lost Spice");
            spiceGirls.Add("Scary Spice");
            spiceGirls.Add("Baby Spice");
            spiceGirls.Add("Pumpkin Spice");
            spiceGirls.Add("Sporty Spice");
            spiceGirls.Add("Spider Spice");
            spiceGirls.Add("Melon Spice");
            spiceGirls.Add("Sigourney Spice");

            Console.WriteLine("Pick a number between 0 and 8:");
            int newFaveSpice = Convert.ToInt16(Console.ReadLine());

            while (newFaveSpice > 8)
            {
                switch (newFaveSpice)
                {
                    default:
                        Console.WriteLine("Whoa there, let's keep it between 0 and 8.");
                        Console.WriteLine("Try again:");
                        newFaveSpice = Convert.ToInt16(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Your new favorite Spice Girl is " + spiceGirls[newFaveSpice]);
            Console.ReadLine();
            Console.WriteLine("Enjoy ur new life lmao");
            Console.Read();
        }
    }
}
