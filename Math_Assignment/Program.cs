using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Math_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person 
            int a, b;
            Console.Write("Anonymous Income Comparison Program: ");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours Wroked?");
            b = int.Parse(Console.ReadLine());

            //Person 2
            int c, d;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours Wroked?");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("The annual salary of Person 1 is { } * { } : { } ", a, b, a * b);


            

            












            Console.ReadLine();

        }
    }
}
