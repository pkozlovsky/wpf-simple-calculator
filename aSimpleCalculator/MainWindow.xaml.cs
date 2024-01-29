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
            oneButton.Click -= NumberButton_Click;
            oneButton.Click += NumberButton_Click;
            twoButton.Click -= NumberButton_Click;
            twoButton.Click += NumberButton_Click;
            threeButton.Click -= NumberButton_Click;
            threeButton.Click += NumberButton_Click;
            fourButton.Click -= NumberButton_Click;
            fourButton.Click += NumberButton_Click;
            fiveButton.Click -= NumberButton_Click;
            fiveButton.Click += NumberButton_Click;
            sixButton.Click -= NumberButton_Click;
            sixButton.Click += NumberButton_Click;
            sevenButton.Click -= NumberButton_Click;
            sevenButton.Click += NumberButton_Click;
            eightButton.Click -= NumberButton_Click;
            eightButton.Click += NumberButton_Click;
            nineButton.Click -= NumberButton_Click;
            nineButton.Click += NumberButton_Click;
            zeroButton.Click -= NumberButton_Click;
            zeroButton.Click += NumberButton_Click;
        }
        //writing the event handlers
        // Number buttons all in one trial: NumberButton_Click to be used for all number buttons
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == zeroButton)
            {
                selectedValue = 0;
            }
            if (sender == oneButton)
            {
                selectedValue = 1;
            }
            if (sender == twoButton)
            {
                selectedValue = 2;
            }
            if (sender == threeButton)
            {
                selectedValue = 3;
            }
            if (sender == fourButton)
            {
                selectedValue = 4;
            }
            if (sender == fiveButton)
            {
                selectedValue = 5;
            }
            if (sender == sixButton)
            {
                selectedValue = 6;
            }
            if (sender == sevenButton)
            {
                selectedValue = 7;
            }
            if (sender == eightButton)
            {
                selectedValue = 8;
            }
            if (sender == nineButton)
            {
                selectedValue = 9;
            }

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
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
                lastNumber = lastNumber * -1;
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