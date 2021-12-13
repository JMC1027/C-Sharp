using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Integers num = new Integers(); //part 2
            Console.WriteLine("Please choose any number you'd like to add to 20");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int result = num.MathOperations(number1);
            Console.WriteLine("The total is: " + result);
            Console.ReadLine();
          
            
            
            num.MathOperations(number1); //calling the method
            Console.WriteLine("The user input is: " + number1); //passes and displays the input int 
            
            Console.WriteLine("Pass in a decimal number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num.MathOperations(number2));
           

            Console.WriteLine("Pass in any word");
            string num3 = Console.ReadLine();
            Console.WriteLine(num.MathOperations(num3));
            Console.ReadLine();



            






        }
    }
}
