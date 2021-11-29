using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           
            
            Console.WriteLine("Welcome to JM Insurance! Before We begin we have some questions for you to answer");
            Console.WriteLine("Question 1: What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Answer True/False");
            string DUI = Console.ReadLine();
            bool hasDUI = false; //bool variable 
            
                  
            if (DUI == "True")
            {
                Console.WriteLine("You do have a DUI");
                hasDUI = true; //returns true 
            } else if (DUI == "False")
            {
                Console.WriteLine("You do not have a DUI");
                hasDUI = false; // returns false 

            } else
            {
                Console.WriteLine("Please answer True or False");// returns message saying " Please answer true or false
            }
            Console.WriteLine(hasDUI);   
            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine()); //ticket number variable converted to int, user input 
            Console.WriteLine("Does The applicant qualify to continue the application process?");
            bool qualified = ((age > 15) && !hasDUI && (numTickets <= 3)); //bool expression compared to user input (Will return True or False)
            Console.WriteLine(qualified);
  
            Console.ReadLine();

        }
    }
}
