using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee(); //Instantiated the class
            employee.FirstName = "Sample"; //initalized class emplyee object 
            employee.LastName = "Student"; // initalized class employee object
            employee.SayName(); //sayname method is called on employee object. 
            Console.ReadLine();
            //Class person is the is the superclasss, emplayee class is inheriting from class person and calling the method sayname()
        }
    }
}
