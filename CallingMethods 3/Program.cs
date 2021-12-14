using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math_Operations Math_Operations = new Math_Operations();//instatiating the class 
            Console.WriteLine("Please enter one number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Option to enter a 2nd number, if not leave blank");
                int userInput1 = Convert.ToInt32(Console.ReadLine());
                Math_Operations.math(userInput, userInput1);
            }
            catch
            {
                Math_Operations.math(userInput);
            }
                Console.ReadLine();

        }  
    }
}
