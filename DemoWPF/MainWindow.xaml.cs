using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DemoWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MinText.Text += button.Content;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MinText.Text = "";
            }
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            var expression = MinText.Text;

            var numbers = expression.Split('+');
            var num1 = int.Parse(numbers[0]);
            var num2 = int.Parse(numbers[1]);

            var sum = num1 + num2;

            MinText.Text = $"{sum}";
        }
    }
}
