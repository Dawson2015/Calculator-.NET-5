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
        SelectedOperator selectedOperator;
        public MainWindow()//constructor
        {
            InitializeComponent();
            acButton.Click += AcButton_Click;
            negativeButton.Click += NegativeButton_Click;
            percentageButton.Click += PercentageButton_Click;
            equalButton.Click += EqualButton_Click;
            //sevenButton.Click += NumberButton_Click;
            //eightButton.Click += NumberButton_Click;
            //nineButton.Click += NumberButton_Click;
            //fourButton.Click += NumberButton_Click;
            //fiveButton.Click += NumberButton_Click;
            //sixButton.Click += NumberButton_Click;
            //oneButton.Click += NumberButton_Click;
            //twoButton.Click += NumberButton_Click;
            //threeButton.Click += NumberButton_Click;
            //zeroButton.Click += NumberButton_Click;

        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if(Double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = SimpleMath.Add(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Subtraction:
                        result = SimpleMath.Subtract(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = SimpleMath.Multiply(lastNumber, newNumber);
                        break;
                    case SelectedOperator.Division:
                        result = SimpleMath.Divide(lastNumber, newNumber);
                        break;
                }
                resultLabel.Content = result.ToString();
            }
        }

        private void PercentageButton_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                //resultLabel.Content = $"{lastNumber * 100}%";
                //lastNumber = lastNumber / 100;
                resultLabel.Content = (lastNumber/100).ToString();
            }
        }

        private void NegativeButton_Click(object sender, RoutedEventArgs e)
        {
            //resultLabel.Content = $"-{resultLabel.Content}";
            if(Double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                if(lastNumber!= 0)
                { 
                    lastNumber = lastNumber * -1;
                    resultLabel.Content = lastNumber.ToString();
                }
                else
                {
                    resultLabel.Content = lastNumber.ToString();
                }
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)//event handler method
        {
            resultLabel.Content = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(resultLabel.Content.ToString(), out lastNumber))//assign the variable "lastNumber"
            {
                resultLabel.Content = "0";
            }

            if(sender == multipleButton)
            {
                selectedOperator = SelectedOperator.Multiplication;
            }
            if(sender == slashButton)
            {
                selectedOperator = SelectedOperator.Division;
            }
            if(sender== plusButton)
            {
                selectedOperator = SelectedOperator.Addition;
            }
            if(sender == dashButton)
            {
                selectedOperator = SelectedOperator.Subtraction;
            }
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
                //Do nothing
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            //int selectedValue = 0;

            //if (sender == zeroButton)//if the zeroButton was pressed
            //{
            //    selectedValue = 0;
            //}
            //if(sender == oneButton)
            //{
            //    selectedValue = 1;
            //}
            //if(sender== twoButton)
            //{
            //    selectedValue = 2;
            //}
            //if (sender == threeButton)
            //{
            //    selectedValue = 3;
            //}
            //if (sender == fourButton)
            //{
            //    selectedValue = 4;
            //}
            //if(sender == fiveButton)
            //{
            //    selectedValue = 5;
            //}
            //if(sender == sixButton)
            //{
            //    selectedValue = 6;
            //}
            //if (sender == sevenButton)
            //{
            //    selectedValue = 7;
            //}
            //if (sender == eightButton)
            //{
            //    selectedValue = 8;
            //}
            //if (sender == nineButton)
            //{
            //    selectedValue = 9;
            //}

            int selectedValue = Convert.ToInt32((sender as Button).Content);

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }

        }
    }

    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    public class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divide(double n1, double n2)
        {
            return n1/ n2;
        }
    }
}
