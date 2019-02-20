using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        class Program
        {
            static void Main(string[] args)
            {
        try
        {
            Console.WriteLine("Pick a number");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Pick a second number");
            int numberTwo = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = number / numberTwo;
            Console.WriteLine(number + " divided by " + numberTwo + " = " + numberThree);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        

        }
            }
