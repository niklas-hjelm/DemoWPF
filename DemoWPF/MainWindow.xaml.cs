using System.Windows;
using System.Windows.Controls;

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
            if(e.Source is Button btn)
            {
                if(btn.Content != null)
                    MinText.Text = btn.Content.ToString();
            }
            else
            {

                MinText.Text = Input.Text;
            }
        }
    }
}
