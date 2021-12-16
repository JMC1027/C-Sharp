using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is it?");
                string userInput = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek),userInput);
                Console.ReadLine();
              
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please Enter the actual day of the week");
                Console.ReadLine();
                
            }
            finally
            {
                Console.WriteLine("Correct, good job!");
                Console.ReadLine();
            }

        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednsday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
