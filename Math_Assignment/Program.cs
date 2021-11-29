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
            int num1, num2, num3, sum;
            Console.WriteLine("Anonymous Income Comparison Program: ");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            num1 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Hours Wroked?");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weeks Wroked?");
            num3 = Convert.ToInt32(Console.ReadLine());
             
            

            //Person 2
            int num4, num5, num6, total;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Wroked?");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weeks Wroked?");
            num6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1 is: ");
            sum = num1 * num2 * num3;
            Console.Write(num1 * num2 * num3);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2 is: ");
            total = num4 * num5 * num6;
            Console.Write(num4 * num5 * num6);
            Console.ReadLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = num1 * num2 * num3;
            int person2 = num4 * num5 * num6;

            bool tf = person1 > person2;
            Console.Write(tf);
            Console.ReadLine();
            


        }
    }
}
