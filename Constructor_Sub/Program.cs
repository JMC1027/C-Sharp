using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Sub
{
    public class Program
    {
        //public const string Name = "Joe";

        static void Main(string[] args)
        {
            const string Name = "Joe";
            var age = 31;
            TwoVars vars = new TwoVars(Name, age);
            Console.ReadLine();

        }
       

    }
}
