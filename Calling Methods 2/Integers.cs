using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_2
{
    public class Integers
    {
        public int MathOperations(int number1) //part 1
        {
            return 20 + number1;
        }
        public int MathOperations(double number2) //psrt 3
        {
            int convertedIntNum = Convert.ToInt32(number2);
            return convertedIntNum * 5;
        }
        public int MathOperations(string number3)
        {
            int convertToInt = Convert.ToInt32(number3);
            return convertToInt;
        }
     
    }
}
