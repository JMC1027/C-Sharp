using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Islanders", "Bruins", "Penguins", "Capitals" };
            Console.WriteLine("Input some text");
            string userInput = Console.ReadLine();
            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine(teams[i] + userInput);
            }
            Console.ReadLine();

            for (int i = 0; i < teams.Length; i++)
            {
                Console.WriteLine(teams[i]);
            }
            Console.ReadLine();
            for (int i = 0; i < teams.Length; i++)
                while (i <= teams.Length)
                {
                    Console.WriteLine(teams[0]);
                    break;
                }
            Console.ReadLine();

            string[] music = { "Country", "Rap", "Rock", "EDM" };
            for (int i = 0; i < music.Length;)
            {
                if (i < music.Length)
                {
                    Console.WriteLine(music[1]);
                }
                if (i <= music.Length)
                {
                    Console.WriteLine(music[0]);
                    break;
                }
            }
            Console.ReadLine();

            List<string> newTeams = new List<string>() { "Raiders", "Giants", "Bills", "Jets" };
            Console.WriteLine("Please choose from the following: Raiders, Giants, Bills, Jets");
            string newUserInput = Console.ReadLine();
            for (int i = 0; i < newTeams.Count; i++)
            {

                if (newTeams[i] == newUserInput)
                {
                    Console.WriteLine("You chose: " + newUserInput);
                    Console.WriteLine("This has an index of: " + i);
                    break;
                }
                if (!newTeams.Contains(newUserInput))
                {
                    Console.WriteLine("Input is not valid");
                }
            }
            Console.ReadLine();

            List<string> newMusic = new List<string>() { "Country", "Rap", "EDM", "Rap" };
            Console.WriteLine("Please choose from the following: Country, Rap, EDM");
            string userInputTwo = Console.ReadLine();
            for (int i = 0; i < newMusic.Count; i++)
            {
                if (newMusic[i] == userInputTwo)
                {
                    Console.WriteLine("You chose: " + userInputTwo);
                    Console.WriteLine("This has an index of: " + i);

                }
                if (!newMusic.Contains(userInputTwo))
                {
                    Console.WriteLine("Input is invalid");
                }
            }
            Console.ReadLine();

            List<string> beer = new List<string>() { "Bud Light", "Corona", "Miller", "Miller" };
            List<string> beerCopy = new List<string>();
            foreach (string item in beer)
            {
                if (beerCopy.Contains(item))
                {
                    Console.WriteLine(item + " has appeared before");
                }
                else
                {
                    Console.WriteLine(item + " has not appeared");
                }
                beerCopy.Add(item);
            }
            Console.ReadLine();
        }

    }

        
}
