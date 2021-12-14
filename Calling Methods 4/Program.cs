using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_Operations_Void Math_Operations_Void = new Math_Operations_Void();// instantiate the class 
            Console.WriteLine("Pass in a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pass in a 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Math_Operations_Void.math(num1, num2);
            Console.ReadLine();
        }
    }
}
