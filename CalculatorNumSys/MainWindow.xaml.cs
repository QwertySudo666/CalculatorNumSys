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

        private void Perevod_Click(object sender, RoutedEventArgs e)
        { 
            TextBox inOtherSys = new TextBox();
            inOtherSys.Width = 105;
            inOtherSys.Height = 30;
            inOtherSys.Text = "В какую сист";
            LayoutGrid.Children.Add(inOtherSys);
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            Answer.Content = sysnumList.SelectedItem;
        }
    }
}
