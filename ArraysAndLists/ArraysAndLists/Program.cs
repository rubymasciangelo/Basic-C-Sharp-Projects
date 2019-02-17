using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //same thing but cleaner and you don't have to set the length

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //it can guess that you want to make an int array

        numArray2[5] = 650;
        //changing value

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
   
        }
    }

