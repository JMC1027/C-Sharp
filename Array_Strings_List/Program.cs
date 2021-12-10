using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Strings_List
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number between 0 and 3");
            string[] teams = { "Islanders", "Bruins", "Capitals", "Penguins" };
            int userInput = int.Parse(Console.ReadLine());
            if (userInput > 3)
            {
                Console.WriteLine("You have chosen an invalid number");
            }
            else if (userInput  <= 3)
            {
                Console.WriteLine(teams[userInput]);
            }
            Console.ReadLine();
            
           Console.WriteLine("Please enter a number between 0 and 3");
           int[] num = { 5, 10, 15, 20 };
           int input = int.Parse(Console.ReadLine());
           if (input > 3)
           {
                Console.WriteLine("You have chosen an invalid number");
           }
           else
           {
               Console.WriteLine(num[input]);
           }
           Console.ReadLine();


            Console.WriteLine("Please enter a number between 0 and 3");
            List<string> stringList = new List<string>();
            stringList.Add("You have chosen index 0");
            stringList.Add("You have chosen index 1");
            stringList.Add("You have chosen index 2");
            string userList = Console.ReadLine();
            Console.WriteLine("The number you entered is: " + userList);
            Console.ReadLine();








        }
    }
}
