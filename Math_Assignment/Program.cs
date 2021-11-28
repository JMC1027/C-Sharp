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
            int num1, num2, sum;
            Console.WriteLine("Anonymous Income Comparison Program: ");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            num1 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Hours Wroked?");
            num2 = Convert.ToInt32(Console.ReadLine());
            

            //Person 2
            int num3, num4, total;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Wroked?");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1 is: ");
            sum = num1 * num2;
            Console.Write(num1 * num2);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2 is: ");
            total = num3 * num4;
            Console.Write(num3 * num4);
            Console.ReadLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = num1 * num2;
            int person2 = num3 * num4;

            bool tf = person1 >= person2;
            Console.Write(tf);
            Console.ReadLine();
            

           
            


            

        }
    }
}
