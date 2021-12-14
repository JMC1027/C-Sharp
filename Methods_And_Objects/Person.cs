using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects
{
    public class Person 
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //return properties to the console 
        }
        public string FirstName; // property first name 
        public string LastName; // property last name
    }
}
