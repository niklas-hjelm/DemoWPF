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

        private void ShowTextButton_Click(object sender, RoutedEventArgs e)
        {
            MinText.Text = Input.Text;
        }

        private void EnlargeTextButton_Click(object sender, RoutedEventArgs e)
        {
            MinText.FontSize += 10;
        }

        private void ShrinkTextButton_Click(object sender, RoutedEventArgs e)
        {
            MinText.FontSize -= 10;
        }

        private void ChangeToConsolas_Click(object sender, RoutedEventArgs e)
        {
            MinText.FontFamily = new FontFamily("Consolas");
        }

        private void ChangeToComicSans_Click(object sender, RoutedEventArgs e)
        {
            MinText.FontFamily = new FontFamily("Comic Sans MS");
        }
    }
}
