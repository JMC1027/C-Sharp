using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess a team");
            string userInput = (Console.ReadLine().ToLower()); //string variable, To.Lower automatically changes user input to lowercase 
            bool isGuessed = userInput == "raiders"; 

            do //do while statement 
            {
                switch (userInput)
                {
                    case "giants":
                        Console.WriteLine("You guessed giants, Try again");                        
                        userInput = Console.ReadLine().ToLower();
                        break;

                    case "jets":
                        Console.WriteLine("You guessed jets, Try again");
                        userInput = Console.ReadLine().ToLower();
                        break;
                    
                    case "raiders":
                        Console.WriteLine("You guessed raiders, Good Job");
                        isGuessed = true;
                        break;
                    
                    default:
                        Console.WriteLine("You are wrong, Guess again");
                        userInput = Console.ReadLine().ToLower();
                        break;

                }

            }
            while (!isGuessed);
//--------------------------------------------------------------------------------------------//
           
            Console.WriteLine("How many players are on the team?");
            int numplayers = Convert.ToInt32(Console.ReadLine()); // int variable 
            bool playerCount = false;

            while (!playerCount) //while statement 
            {
                if (numplayers == 55) //number of players equals 55 
                {
                    Console.WriteLine("You guessed correct");
                    playerCount = true;
                }
                else if (numplayers <= 65 && numplayers >= 45)

                {
                    Console.WriteLine("You were really close, Guess again");
                    numplayers = Convert.ToInt32(Console.ReadLine());
                    
                } 
                else
                {
                    Console.WriteLine("You guessed wrong, Guess again");
                    numplayers = Convert.ToInt32(Console.ReadLine());
                }
            }
                
         
           

            Console.Read();

        }
    }
}
