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
            int remainder, result;
            while (num >= system)
            {
                result = num / system;
                remainder = num - (result * system);
                num = result;
                Console.Write(remainder);
                //Console.WriteLine(result);
            }
            Console.WriteLine(num);
        }
    }
}
