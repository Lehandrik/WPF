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

namespace WPF3_HW
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
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (AgreementCheckBox.IsChecked != true)
            {
                MessageBox.Show("Необходимо дать согласие на обработку персональных данных!",
                              "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(StudentNameTextBox.Text))
            {
                MessageBox.Show("Введите имя студента!", "Ошибка",
                              MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var selectedCourses = CoursesListBox.SelectedItems
                .Cast<ListBoxItem>()
                .Select(item => item.Content.ToString())
                .ToList();

            // Формирование сообщения
            string message = $"Заявка подана!\n\n" +
                           $"Студент: {StudentNameTextBox.Text}\n" +
                           $"Факультет: {FacultyComboBox.Text}\n" +
                           $"Форма обучения: {(FullTimeRadio.IsChecked == true ? "Очно" : "Заочно")}\n" +
                           $"Выбранные курсы:\n{string.Join("\n", selectedCourses)}";

            MessageBox.Show(message, "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}