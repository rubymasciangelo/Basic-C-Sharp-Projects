﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an integer to do some math to:");
            Int16 inputNum = Convert.ToInt16(Console.ReadLine());
            int input1 = Math.Multiply(inputNum);
            Console.WriteLine(inputNum + " multiplied by 3 is " + input1 );


            Console.ReadLine();
        }
    }
}