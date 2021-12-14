using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your First Name");
            string Fname = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Type in your Last Name");
            string Lname = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Name: " + Fname + " " + Lname);
            Console.ReadLine();
        }
    }
}
