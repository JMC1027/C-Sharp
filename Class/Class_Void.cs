using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Class_Void
    {
        public int Math(int num1)
        {          
             return num1 / 2;
        }
        public int Math(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public int OutMethod(out int num1)
        {
            num1 = 100;
            return num1 / 2;
        }

    }
    
}
