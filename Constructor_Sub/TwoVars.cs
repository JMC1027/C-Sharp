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
        public int age { get; set; }
        public TwoVars(string name) : this(name, 31)
        {
            Console.WriteLine(name + "is your name and your default age is " + age);
        }
        public TwoVars(string name, int age)
        {
            this.Name = Name;
            this.age = age;
            Console.WriteLine(name + "is your name and your age is " + age);

            TwoVars vars = new TwoVars(Name, age);
            Console.ReadLine();
        }
    }
}
