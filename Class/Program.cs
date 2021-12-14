using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Void Class_Void = new Class_Void();
            Console.WriteLine("Pass in a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Class_Void.Math(out num1);
            Console.WriteLine("Your number divided by 2 is: " + num1 / 2);
            Console.ReadLine();
        }

    }
}
