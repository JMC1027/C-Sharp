using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers anum = new Numbers(); //calling method from program.cs
            Console.WriteLine("What number do you want to add 10 to?");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = anum.AddTwoNumbers(number);
            Console.WriteLine("Here is the results of your math operation: " + result);
            Console.ReadLine();

            Console.WriteLine("What is a number you'd like to square?");
            number = Convert.ToInt32(Console.ReadLine());
            result = anum.SquareTheNumber(number);
            Console.WriteLine("Here is the results of your math operation: " + result);
            Console.ReadLine();

            Console.WriteLine("What is a number you'd like to divide by 2?");
            number = Convert.ToInt32(Console.ReadLine());
            result = anum.DivideTheNumber(number);
            Console.WriteLine("Here is the results of your math operation: " + result);
            Console.ReadLine();

        }
    }
}
