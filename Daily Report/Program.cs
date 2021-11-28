using System;


namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");//The tech academy is returned
            Console.WriteLine("Student Daily Report");//Same result as above
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);//concatinating console.WriteLine + users input 

            Console.WriteLine("What course are you on?");//Same as above
            string currentCourse = Console.ReadLine();
            Console.WriteLine("your current course is: " + currentCourse);

            Console.WriteLine("What page number?");//same as above
            string pageNumber = Console.ReadLine();
            Console.WriteLine("your current page number is: " + pageNumber);


            Console.WriteLine("Do you need help with anything, Please answer True/False");
            string needsHelp = Console.ReadLine();
            Console.WriteLine(": " + needsHelp);
            bool needsHelpBool = bool.Parse(needsHelp);
            if (needsHelpBool) //Created an if/else statement to return statements depending on if user inputs true or false
            {
                Console.WriteLine("You need some help");//Returned if user types in True 
            }
            else
            {
                Console.WriteLine("You do not need help");//Returned if user types in false 
            }

            Console.WriteLine("Were there any positive experiences youd like to share?");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback");

            Console.WriteLine("How many hours did you study?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("your total hours studied is: " + hoursStudied);//user inputs their total number hours studied and the program outputs a string + user input 

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");//Last message to user after all questions have been answered
            Console.ReadLine();
        }
    }
}
