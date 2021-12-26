using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Sub
{
    public class TwoVars 
    {
        public string Name { get; set; }
        public int Age { get; set; }

           public TwoVars(string name) : this(name, 31);

        public TwoVars(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
