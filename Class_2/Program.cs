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
            Employee Employee = new Employee();
            Employee.FirstName = "Sample";
            Employee.LastName = "Student";
            Employee.SayName();
            Console.ReadLine();
        }
    }
}
