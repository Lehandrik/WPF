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

namespace WPF1_HW3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RunawayButton_MouseEnter(object sender, MouseEventArgs e)
        {
            // Получаем размеры окна и кнопки
            double windowWidth = MainWindow1.ActualWidth;
            double windowHeight = MainWindow1.ActualHeight;
            double buttonWidth = MoveButton.ActualWidth;
            double buttonHeight = MoveButton.ActualHeight;

            // Вычисляем максимальные координаты для кнопки
            double maxX = windowWidth - buttonWidth - 10; // -10 для отступов от краев
            double maxY = windowHeight - buttonHeight - 10;

            // Генерируем случайные координаты
            double newX = _random.Next(10, (int)maxX);
            double newY = _random.Next(10, (int)maxY);

            // Устанавливаем новые координаты кнопки через Margin
            MoveButton.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}