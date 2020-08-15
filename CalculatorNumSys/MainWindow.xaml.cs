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
            int num1 = int.Parse(firstNum.Text);
            int num2 = int.Parse(secondNum.Text);
            int result = num1 + num2;
            Answer.Content = "Result: " + result;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(firstNum.Text);
            int num2 = int.Parse(secondNum.Text);
            int result = num1 - num2;
            Answer.Content = "Result: " + result;
        }

        private void Mn_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(firstNum.Text);
            int num2 = int.Parse(secondNum.Text);
            int result = num1 * num2;
            Answer.Content = "Result: " + result;
        }

        private void Dil_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(firstNum.Text);
            int num2 = int.Parse(secondNum.Text);
            double result = (double)num1 / (double)num2;
            Answer.Content = "Result: " + result;
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
                SysNumMath.Print(num, system);
            }
        }
    }
}
