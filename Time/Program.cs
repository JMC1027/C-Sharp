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
            Console.WriteLine(time.ToString("MM/dd/yyyy"));//Prints current date to console
            Console.ReadLine();
            Console.WriteLine("Input a number");//Asking user for an int input
            int x = Convert.ToInt32(Console.ReadLine()); //user input = x Converts string to int
            Console.ReadLine();
            TimeSpan z = new System.TimeSpan(x);  //timespan z instantiates new timespan, using user input as object(x)
            DateTime y = time.AddHours(x); //adding current date date to user input 
            Console.WriteLine(y);//displays var y as conversion of user input and current date time
            Console.ReadLine();
           
        }
    }
}
