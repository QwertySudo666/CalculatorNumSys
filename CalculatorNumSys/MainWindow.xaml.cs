using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorNumSys
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = "Result: ";
            int system = Convert.ToInt32(sysnumList.SelectedItem);
            int system_2 = Convert.ToInt32(sysnumList_2.SelectedItem);
            string num = firstNum.Text;
            string num_2 = secondNum.Text;

            int result = SysNumMath.toDecimal(system, num) + SysNumMath.toDecimal(system_2, num_2);
            int res_sys = Convert.ToInt32(result_sysnumList.SelectedItem);
            List<string> arrResult = new List<string>();
            arrResult = SysNumMath.FromDecimal(result, res_sys);
            if (res_sys != 10)
            {
                for (int i = 0; i < arrResult.Count; i++)
                {
                    Answer.Content += arrResult[i];
                }
            }
            else
            {
                Answer.Content += Convert.ToString(result);
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = "Result: ";
            int system = Convert.ToInt32(sysnumList.SelectedItem);
            int system_2 = Convert.ToInt32(sysnumList_2.SelectedItem);
            string num = firstNum.Text;
            string num_2 = secondNum.Text;

            int result = SysNumMath.toDecimal(system, num) - SysNumMath.toDecimal(system_2, num_2);
            int res_sys = Convert.ToInt32(result_sysnumList.SelectedItem);
            List<string> arrResult = new List<string>();
            arrResult = SysNumMath.FromDecimal(result, res_sys);
            if (res_sys != 10)
            {
                for (int i = 0; i < arrResult.Count; i++)
                {
                    Answer.Content += arrResult[i];
                }
            }
            else
            {
                Answer.Content += Convert.ToString(result);
            }
        }

        private void Mn_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = "Result: ";
            int system = Convert.ToInt32(sysnumList.SelectedItem);
            int system_2 = Convert.ToInt32(sysnumList_2.SelectedItem);
            string num = firstNum.Text;
            string num_2 = secondNum.Text;

            int result = SysNumMath.toDecimal(system, num) * SysNumMath.toDecimal(system_2, num_2);
            int res_sys = Convert.ToInt32(result_sysnumList.SelectedItem);
            List<string> arrResult = new List<string>();
            arrResult = SysNumMath.FromDecimal(result, res_sys);
            if (res_sys != 10)
            {
                for (int i = 0; i < arrResult.Count; i++)
                {
                    Answer.Content += arrResult[i];
                }
            }
            else
            {
                Answer.Content += Convert.ToString(result);
            }
        }

        private void Dil_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = "Result: ";
            int system = Convert.ToInt32(sysnumList.SelectedItem);
            int system_2 = Convert.ToInt32(sysnumList_2.SelectedItem);
            string num = firstNum.Text;
            string num_2 = secondNum.Text;

            int result = SysNumMath.toDecimal(system, num) / SysNumMath.toDecimal(system_2, num_2);
            int res_sys = Convert.ToInt32(result_sysnumList.SelectedItem);
            List<string> arrResult = new List<string>();
            arrResult = SysNumMath.FromDecimal(result, res_sys);
            if (res_sys != 10)
            {
                for (int i = 0; i < arrResult.Count; i++)
                {
                    Answer.Content += arrResult[i];
                }
            }
            else
            {
                Answer.Content += Convert.ToString(result);
            }
        }

        void toTranslate_Click(object sender, RoutedEventArgs e)
        {
            translateResult.Content = "Result: ";
            if (inWhatSystem.Text == "10")
            {
                    translateResult.Content += Convert.ToString(SysNumMath.toDecimal(Convert.ToInt32(sysnumList_3.Text), numForTrans.Text));
            }
            else if (sysnumList_3.Text == "10")
            {
                int num = Convert.ToInt32(numForTrans.Text);
                int system = Convert.ToInt32(inWhatSystem.SelectedItem);

                List<string> fromDec = SysNumMath.FromDecimal(num, system); 
                for(int i = 0; i<fromDec.Count;i++)
                {
                    translateResult.Content += fromDec[i];
                }
            }
            else if (inWhatSystem.Text != "10")
            {
                int from_WhatSystem = (Convert.ToInt32(sysnumList_3.SelectedItem));
                string num_ForTrans = numForTrans.Text;
                int in_WhatSystem = (Convert.ToInt32(inWhatSystem.SelectedItem));
                List<string> newNum = SysNumMath.transToOtherSys(from_WhatSystem, num_ForTrans, in_WhatSystem);
                for (int i = 0; i < newNum.Count; i++)
                {
                    translateResult.Content += newNum[i];
                }
            }
        }
    }
}
