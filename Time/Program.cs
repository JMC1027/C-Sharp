using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("MM/dd/yyyy"));
            Console.ReadLine();
            Console.WriteLine("Input a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            TimeSpan z = new System.TimeSpan(x);
            DateTime y = time.AddHours(x);
            Console.WriteLine(y);
            Console.ReadLine();
           
        }
    }
}
