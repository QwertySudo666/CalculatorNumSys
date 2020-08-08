using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNumSys
{
    class SysNumMath
    {
        public static List<int> FromDecimal(int num, int system)
        {
            int remainder;
            List<int> newNum = new List<int>();
            while (num >= system)
            {
                remainder = num % system;
                num /= system;
                newNum.Add(remainder);
            }
            newNum.Add(num);
            return newNum;
        }
        public static void Print()
        {
            List<int> numb = FromDecimal(10, 2);
            for (int i = (numb.Count() - 1); i >= 0; i--)
            {
                Console.Write(numb[i]);
            }
        }
    }
}
