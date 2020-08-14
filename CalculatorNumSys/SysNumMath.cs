﻿using System;
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
        public static void Print(int num, int system)
        {
            List<int> numb = FromDecimal(num, system);
            for (int i = (numb.Count() - 1); i >= 0; i--)
            {
                foreach (MainWindow labelAnswer in Application.Current.Windows)
                {
                    if (labelAnswer.translateResult.GetType() == typeof(Label))
                    {
                        labelAnswer.translateResult.Content += Convert.ToString(numb[i]);
                    }
                }
            }
        }
    }
}
