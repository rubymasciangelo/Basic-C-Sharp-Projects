using System;
using System.Collections.Generic;

namespace WeirdlyExcessiveExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create 1D string[], ask user to input text, Create a loop that goes through eachstring in the array
            //   adding the user's text to the string. Then create a loop that prints each string on a separate line

            //Console.WriteLine("Type any singular noun:");
            //string noun1 = Console.ReadLine();

            //Console.WriteLine("Type any plural noun:");
            //string noun2 = Console.ReadLine();

            //Console.WriteLine("Type any amount of time:");
            //string time1 = Console.ReadLine();

            //Console.WriteLine("Type any abstract concept:");
            //string concept1 = Console.ReadLine();

            //string[] wannabe = { "If you wanna be my " + noun1, "You gotta get with my " + noun2, "Make it last " + time1, "Cause " + concept1 + " never ends!", };

            //for (int j = 0; j < wannabe.Length; j++)
            //{
            //    Console.WriteLine(wannabe[j]);
            //}
            //Console.ReadLine();

            //2. Create an infinite loop

            //Console.WriteLine("Insult me:");
            //string insult = Console.ReadLine();

            //while (true)
            //{
            //    switch (insult)
            //    {
            //        default:
            //            Console.WriteLine("I'm rubber, you're glue! Whatever you say bounces off me and sticks to you!");
            //            Console.WriteLine("Insult me:");
            //            insult = Console.ReadLine();
            //            break;
            //    }
                
            //}

            //3. Fix the infinite loop so it will execute

            Console.WriteLine("Insult me:");
            string insult = Console.ReadLine();

            while (insult != "Cats don't like you")
            {
                switch (insult)
                {
                    default:
                        Console.WriteLine("I'm rubber, you're glue! Whatever you say bounces off me and sticks to you!");
                        Console.WriteLine("Insult me:");
                        insult = Console.ReadLine();
                        break;

                    case "Cats don't like you":
                        Console.WriteLine("How Dare You");
                        Console.ReadLine();
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
