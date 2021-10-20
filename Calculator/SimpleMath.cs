using System.Windows;

namespace Calculator
{
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
            if (n2 == 0)
            {
                MessageBox.Show("Divided by 0 is not supported.","Wrong option",MessageBoxButton.OK,MessageBoxImage.Error);
                return 0;
            }
            return n1/ n2;
        }
    }
}
