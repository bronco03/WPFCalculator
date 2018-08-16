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

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> numbers = new List<string>();
        List<string> operators = new List<string>();
        string actualNumber = "0";
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            
            if (Tb.Text.Equals("0"))
            {
                actualNumber = ((Button)sender).Content.ToString();
                Tb.Text = ((Button)sender).Content.ToString();

            }
            else
            {
                actualNumber = actualNumber + ((Button)sender).Content.ToString();
                Tb.Text += ((Button)sender).Content.ToString();
            }

        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(actualNumber);
            operators.Add(((Button)sender).Content.ToString());
            Tb.Text = "0";

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(actualNumber);
            int i = 0;
            int act = int.Parse(numbers[i]);
            foreach (string a in operators)
            {
                i++;
                switch (a) {

                    case "+": act = act + int.Parse(numbers[i]);
                        break;
                    case "-":
                        act = act - int.Parse(numbers[i]);
                        break;
                    case "*":
                        act = act * int.Parse(numbers[i]);
                        break;
                    case "/":
                        act = act / int.Parse(numbers[i]);
                        break;
                }
                
            }
            Tb.Text = act.ToString();
        }
    }
}
