using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNumSys
{
    class SysNumMath
    {
        public static void fromDecimal(int num, int system)
        {
            int remainder;
            while (num >= system)
            {
                remainder = num % system;
                num = num / system;
            }
            Console.WriteLine(num);
        }
    }
}
