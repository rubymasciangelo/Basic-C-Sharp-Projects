﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            string input1 = Console.ReadLine();

            BigStaticClass printResult = new BigStaticClass();
            printResult.HalfIt(input1);

            //BigStaticClass hmmm = new BigStaticClass();
            //hmmm.Confuse(out input1); //an out parameter that displays a message in response to input being entered

            Console.WriteLine(BigStaticClass.Confuse(out input1));

            Console.ReadKey();

            Console.WriteLine("Are you a bird: yes or no");
            string inputBird = Console.ReadLine();
            Console.WriteLine("Have you seen a bird today? If you have not, just hit enter. If you have, type yes and hit enter: ");
            string inputSeenBird = Console.ReadLine();

            if (inputSeenBird != "")
            {
                Console.WriteLine(BigStaticClass.Overload(inputBird, inputSeenBird));
            }
            else
            {
                Console.WriteLine(BigStaticClass.Overload(inputBird));
            }
            Console.ReadKey();
        }

        //example sort of
        //{
        //    int a;
        //    int b;
        //    Program p = new Program();
        //    p.DoSomething(out a, out b);
        //}
        //public void DoSomething(out int x, out int y)
        //{
        //    x = 5;
        //    y = 20;
        //}
    }
}
