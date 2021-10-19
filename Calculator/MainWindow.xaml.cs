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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber,result;
        public MainWindow()//constructor
        {
            InitializeComponent();
            //resultLabel.Content = "123";
            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            //resultLabel.Content = $"-{resultLabel.Content}";
            if(Double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)//event handler method
        {
            resultLabel.Content = "0";
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }

        }
    }
}
