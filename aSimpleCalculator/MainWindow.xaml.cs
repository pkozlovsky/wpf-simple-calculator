using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aSimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;

        public MainWindow()
        {
            InitializeComponent();
            resultLabel.Content = "0";
            //registering the event handlers
            acButton.Click -= acButton_Click;
            acButton.Click += acButton_Click;
            plusMinusButton.Click -= plusMinusButton_Click;
            plusMinusButton.Click += plusMinusButton_Click;
            percentButton.Click -= percentButton_Click;
            percentButton.Click += percentButton_Click;
            divideButton.Click -= divideButton_Click;
            divideButton.Click += divideButton_Click;
            multiplyButton.Click -= multiplyButton_Click;
            multiplyButton.Click += multiplyButton_Click;
            minusButton.Click -= minusButton_Click;
            minusButton.Click += minusButton_Click;
            addButton.Click -= addButton_Click;
            addButton.Click += addButton_Click;
            equalsButton.Click -= equalsButton_Click;
            equalsButton.Click += equalsButton_Click;
            decimalButton.Click -= decimalButton_Click;
            decimalButton.Click += decimalButton_Click;
            oneButton.Click -= oneButton_Click;
            oneButton.Click += oneButton_Click;
            twoButton.Click -= twoButton_Click;
            twoButton.Click += twoButton_Click;
            threeButton.Click -= threeButton_Click;
            threeButton.Click += threeButton_Click;
            fourButton.Click -= fourButton_Click;
            fourButton.Click += fourButton_Click;
            fiveButton.Click -= fiveButton_Click;
            fiveButton.Click += fiveButton_Click;
            sixButton.Click -= sixButton_Click;
            sixButton.Click += sixButton_Click;
            sevenButton.Click -= sevenButton_Click;
            sevenButton.Click += sevenButton_Click;
            eightButton.Click -= eightButton_Click;
            eightButton.Click += eightButton_Click;
            nineButton.Click -= nineButton_Click;
            nineButton.Click += nineButton_Click;
            zeroButton.Click -= zeroButton_Click;
            zeroButton.Click += zeroButton_Click;
        }
        //writing the event handlers
        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "1";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}1";
            }
        }
        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "2";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}2";
            }
        }
        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "3";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}3";
            }
        }
        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "4";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}4";
            }
        }
        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "5";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}5";
            }
        }
        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "6";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}6";
            }
        }
        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }
        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "8";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}8";
            }
        }
        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "9";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}9";
            }
        }
        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                return;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}0";
            }
        }
        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }
        private void plusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -2;
                resultLabel.Content = lastNumber.ToString();
            }
        }
        private void percentButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for % button
            // Implement the logic for percentage calculation
        }
        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for / button
            // Implement the logic for division
        }
        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for * button
            // Implement the logic for multiplication
        }
     
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for + button
            // Implement the logic for addition
        }
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for + button
            // Implement the logic for addition
        }
        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for = button
            // Implement the logic for calculating the result
        }
        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            // Code for = button
            // Implement the logic for calculating the result
        }
    }
}