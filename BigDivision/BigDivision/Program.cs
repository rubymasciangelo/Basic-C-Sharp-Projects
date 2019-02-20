using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            
                List<int> numbers = new List<int>() { 4, 8, 15, 16, 23, 32 };
                Console.WriteLine("Choose a number to divide a list of numbers by:");
                
            foreach (int number in numbers)
            {
                try
                {
                    int numChoice = Convert.ToInt16(Console.ReadLine());
                    int numAnswer = number / numChoice;
                    Console.WriteLine(number + " divided by " + numChoice + " = " + numAnswer);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                finally
                {
                    Console.WriteLine("ThE pRoGrAm HaS EmErGeD fRoM tHe TrY cAtCh BlOcK");
                }
            }
            Console.ReadLine();
        }
    }
}
