using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 98, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

            Console.ReadLine();

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
            }

            Console.ReadLine();

        }
    }
}
