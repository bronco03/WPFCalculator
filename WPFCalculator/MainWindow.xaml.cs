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

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if(Tb.Text.Equals("0")) Tb.Text = ((Button)sender).Content.ToString();
            else Tb.Text += ((Button)sender).Content;
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Tb.Text += ((Button)sender).Content;
        }
    }
}
