using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_3
{
    public class Math_Operations
    {
        public void math(int num1, int num2 = 0)//int num2 is optional 
        {
            int x = num1 + num2 * 5;
            Console.WriteLine(x);
        }
    }
}
