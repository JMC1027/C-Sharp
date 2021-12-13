using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Numbers
    {
        public int AddTwoNumbers(int num) //method 1
        {
            return 10 + num;
        }
        public int SquareTheNumber(int num) // method 2
        {
            return num * num;
        }
        public int DivideTheNumber(int num) //method 3
        {
            return num / 2; 
        }
    }
}
