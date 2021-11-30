using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Packge Express");
            Console.WriteLine("What is your packages weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if ( weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
            }
            else
            {
                Console.WriteLine("What is your package width?");
            }
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your packages length?");
            int length = Convert.ToInt32(Console.ReadLine());
            int packageTotal = height * length * width / 100; //variable = math equation to calculate package cost 
            int totalSize = 50;

            if (packageTotal > totalSize)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.");
                
            }
            else if (packageTotal <= totalSize)
            {
                Console.WriteLine("Your estimated total for shipping this package is:");
                Console.WriteLine(packageTotal);
            }
            Console.ReadLine();
          
            Console.WriteLine("Have a good day!");

            Console.Read();
        }
    }
}
