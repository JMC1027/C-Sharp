using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum day = DaysOfTheWeek.Wednsday;
            Console.WriteLine("What day of the week is it?", day.ToString());
        
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednsday,
            Thurday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
