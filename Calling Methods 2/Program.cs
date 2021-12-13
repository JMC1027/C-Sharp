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
            Integers num = new Integers();
            Console.WriteLine("Please choose any number you'd like to add to 20");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int result = num.AddTwoNumbers(number1);
            Console.WriteLine("The total is: " + result);
            Console.ReadLine();

            Integers integers = new Integers(); //instantiate the class
            integers.AddTwoNumbers(number1); //calling the method
            Console.WriteLine(number1); //passes and displays the input int 
            Console.ReadLine(); 


           
             
           

            
        }
    }
}
