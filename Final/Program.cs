using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Final
{
    public class Program : DbContext
    {
        static void Main(string[] args)
        {
            using(var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentFirstName = "Joe", StudentLastName = "Mckenna", };

                ctx.Student.Add(stud);
                ctx.SaveChanges();
            }
        }

    }


}
