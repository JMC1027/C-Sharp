using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee();//Instantiated the class
            Employee.FirstName = "Sample";//intialized class employee object
            Employee.LastName = "Student";
            Employee.SayName();//calling method SayName
            Console.ReadLine();
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
