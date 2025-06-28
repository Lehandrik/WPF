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

namespace WPF1_HW2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _currentState = 0; // 0 - красный, 1 - желтый, 2 - зеленый
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentState == 0)
            {
                _currentState = 1;
            }
            else if (_currentState == 1)
            {
                _currentState = 2;
            }
            else
            {
                _currentState = 0;
            }
            UpdateLights();
        }

        private void UpdateLights()
        {
            // Сначала все сигналы серые
            RedLight.Fill = Brushes.Gray;
            YellowLight.Fill = Brushes.Gray;
            GreenLight.Fill = Brushes.Gray;

            // Включаем текущий активный сигнал
            switch (_currentState)
            {
                case 0: // Красный
                    RedLight.Fill = Brushes.Red;
                    break;
                case 1: // Желтый
                    YellowLight.Fill = Brushes.Yellow;
                    break;
                case 2: // Зеленый
                    GreenLight.Fill = Brushes.Green;
                    break;
            }
        }
    }
}