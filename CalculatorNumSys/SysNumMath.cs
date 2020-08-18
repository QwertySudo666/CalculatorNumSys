using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorNumSys
{
    class SysNumMath
    {
        private static Dictionary<int, string> heximalsLetters_i_to_s()
        {
            Dictionary<int, string> heximalsLetters = new Dictionary<int, string>(6);
            heximalsLetters.Add(10, "A");
            heximalsLetters.Add(11, "B");
            heximalsLetters.Add(12, "C");
            heximalsLetters.Add(13, "D");
            heximalsLetters.Add(14, "E");
            heximalsLetters.Add(15, "F");

            return heximalsLetters;
        }
        private static Dictionary<string, int> heximalsLetters_s_to_i()
        {
            Dictionary<string, int> heximalsLetters = new Dictionary<string, int>(6);
            heximalsLetters.Add("A", 10);
            heximalsLetters.Add("B", 11);
            heximalsLetters.Add("C", 12);
            heximalsLetters.Add("D", 13);
            heximalsLetters.Add("E", 14);
            heximalsLetters.Add("F", 15);

            return heximalsLetters;
        }
        //Ф-я для перевода из 10-ой сист.числ. в 2, 8, 16
        public static List<string> FromDecimal(int num, int system)
        {
            int remainder;
            Dictionary<int, string> hexLetters = heximalsLetters_i_to_s();
            List<string> newNum = new List<string>();

            while (num >= system)
            {
                remainder = num % system;
                num /= system;
                if (remainder > 9)
                {
                    newNum.Add(Convert.ToString(hexLetters[remainder]));
                }
                else
                {
                    newNum.Add(Convert.ToString(remainder));
                }
            }

            if (num > 9)
            {
                newNum.Add(Convert.ToString(hexLetters[num]));
            }
            else
            {
                newNum.Add(Convert.ToString(num));
            }
            newNum.Reverse();
            return newNum;
        }
        //public static void Print(int num, int system)
        //{
        //    List<string> numb = FromDecimal(num, system);
        //    for (int i = (numb.Count() - 1); i >= 0; i--)
        //    {
        //        foreach (MainWindow labelAnswer in Application.Current.Windows)
        //        {
        //            if (labelAnswer.translateResult.GetType() == typeof(Label))
        //            {
        //                labelAnswer.translateResult.Content += Convert.ToString(numb[i]);
        //            }
        //        }
        //    }
        //}

        //Ф-я для перевода из n-ой системы в 10
        //arg int system - система числа num
        public static int toDecimal(int system, string num)
        {
            Dictionary<string, int> heximalsLetters = heximalsLetters_s_to_i();

            int sum = 0;
            double pow = num.Length-1;
            int[] arr = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                switch(num.Substring(i, 1))
                {
                    case "A":
                        arr[i] = Convert.ToInt32(heximalsLetters["A"]);
                        break;
                    case "B":
                        arr[i] = Convert.ToInt32(heximalsLetters["B"]);
                        break;
                    case "C":
                        arr[i] = Convert.ToInt32(heximalsLetters["C"]);
                        break;
                    case "D":
                        arr[i] = Convert.ToInt32(heximalsLetters["D"]);
                        break;
                    case "E":
                        arr[i] = Convert.ToInt32(heximalsLetters["E"]);
                        break;
                    case "F":
                        arr[i] = Convert.ToInt32(heximalsLetters["F"]);
                        break;
                    default:
                        arr[i] = Convert.ToInt32(num.Substring(i, 1));
                        break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] * Convert.ToInt32(Math.Pow(system, pow));
                pow--;
            }
            return sum;
        }

        //Ф-я для перевода из 8 и 16 систем в 2
        public static List<string> toBinary(int system, string num)
        {
            //8 & 16 to 2
            //toDecimal(system, num);
            return FromDecimal(toDecimal(system, num), 2);
        }

        public static List<string> transToOtherSys(int fromWhatSystem, string num, int inWhatSystem)
        {
            return FromDecimal(toDecimal(fromWhatSystem, num), inWhatSystem);
        }
    }
}
