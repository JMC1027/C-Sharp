using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_2
{
    public abstract class Person
    {
        public abstract void SayName();
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }
}
