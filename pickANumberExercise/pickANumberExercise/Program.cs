﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickANumberExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write any number: ");
            string numResponse = Console.ReadLine();
            long inputNum = Convert.ToUInt32(numResponse);
            long multiply = inputNum * 50;
            Console.WriteLine(inputNum + " multiplied by 50 is " + multiply);
            long add = inputNum + 25;
            Console.WriteLine(inputNum + " added to 25 is " + add);
            double divide = inputNum / 12.5;
            Console.WriteLine(inputNum + "divided by 12.5 is " + divide);
            bool compare = inputNum > 50;
            Console.WriteLine(inputNum + " is greater than 50?");
            Console.WriteLine(compare);
            long remainder = inputNum % 7;
            Console.WriteLine(inputNum + " divided by 7 has a remainder of " + remainder);
            Console.Read();
        }
    }
}
