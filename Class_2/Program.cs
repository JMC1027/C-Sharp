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
            Employee employee = new Employee();
            Employee employee2 = new Employee();
            employee.Id = 25; //declaring employee1 Id
            employee2.Id = 25;//declaring employee2 Id
            Console.WriteLine(employee == employee2);
            Console.ReadLine();
 
            Employee Employee = new Employee();//Instantiated the class
            Employee.FirstName = "Sample";//intialized class employee object
            Employee.LastName = "Student";
            Employee.SayName();//calling method SayName
            Console.ReadLine();
            IQuittable quittable = new Employee();//Usiing polymorphism to create object of type IQuittable (quittable is the object)
            quittable.Quit();//Calling the Quit() method
            Console.ReadLine();

        }
    }
}
