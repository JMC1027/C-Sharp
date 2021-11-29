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
            num1 = Convert.ToInt32(Console.ReadLine()); //lets user input their own data           
            Console.WriteLine("Hours Wroked?");
            num2 = Convert.ToInt32(Console.ReadLine()); //same as above
            Console.WriteLine("Weeks Wroked?");
            num3 = Convert.ToInt32(Console.ReadLine()); // same as above
             
            

            //Person 2
            int num4, num5, num6, total;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            num4 = Convert.ToInt32(Console.ReadLine()); // all the same as the above
            Console.WriteLine("Hours Wroked?");
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weeks Wroked?");
            num6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1 is: ");
            sum = num1 * num2 * num3; // takes users input and multiplies it together for the annual salary 
            Console.Write(num1 * num2 * num3); //displays the total number 
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2 is: "); // same as above 
            total = num4 * num5 * num6;
            Console.Write(num4 * num5 * num6);
            Console.ReadLine();
            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = num1 * num2 * num3; //takes the total for both people 
            int person2 = num4 * num5 * num6;

            bool tf = person1 > person2; //displays true or false depending if person 1 makes more or less 
            Console.Write(tf); // tf stands for true/false
            Console.ReadLine();
            


        }
    }
}
