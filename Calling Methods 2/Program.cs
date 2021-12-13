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

            Integers add = new Integers(); //instantiate the class
            add.MathOperations(number1); //calling the method
            Console.WriteLine("The user input is: " + number1); //passes and displays the input int 
            Console.ReadLine();


            Console.WriteLine("Please enter a whole number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose any decimal number you'd like");
            decimal number3 = Decimal.Parse(Console.ReadLine());
            for (decimal value = number3; value == number3; value += .1m)
            {
                Console.WriteLine("The total of both your inputs is: " + number2 * number3, value, Decimal.Round(value));
                break;
            } 



            //Console.WriteLine("The total of both your inputs is: " + number2 * number3);
            Console.ReadLine();

            //Integers multiply = new Integers();
            //multiply.MathOperations(number2, (int)number3);
            //Console.WriteLine("The total is: " + number2 * number3);
            //Console.ReadLine();








        }
    }
}
