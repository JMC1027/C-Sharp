using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myNumbers = new List<int>() { 22, 35, 67, 89, 91, 95, 93 };
                Console.WriteLine("Pick a number you would like to use to divide with");
                int userInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myNumbers.Count; i++)
                {
                    Console.WriteLine(myNumbers[i] / userInput); //divides myNumbers List by the user input 
                }
                Console.ReadLine();

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero");
            }
            Console.ReadLine();
            Console.WriteLine("The program has just completed a try/catch block");
            Console.ReadLine();
            
        }
        
    }
}
