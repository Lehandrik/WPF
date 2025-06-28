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

namespace WPF1_HW1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        // Нажатия кнопки
        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            _counter++;
            CounterTextBlock.Text = _counter.ToString();
        }
    }
}