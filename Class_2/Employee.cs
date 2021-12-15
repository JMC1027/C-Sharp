using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    public class Employee: Person, IQuittable
    {
        public int Id { get; set; }
        public object Person { get; internal set; }

        public override void SayName()
        {
            Console.WriteLine("Name " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("IQuit");//Implimenting IQuit method 
        }
        public static bool  operator ==(Employee Employee1, Employee Employee2) //overloading bool operator 
        {

            return Employee1.Id == Employee2.Id;//returns true if Employee Id's match
        }
        public static bool operator !=(Employee Employee1, Employee Employee2) //requires matching operator of != to also be defined
        {

            return Employee1.Id != Employee2.Id; //returns false if employee id"s dont match 
        }

    }
}
