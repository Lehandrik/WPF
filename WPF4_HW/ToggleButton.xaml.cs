using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF4_HW
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public class ToggleButton : Button
    {
        public static readonly DependencyProperty IsToggledProperty =
            DependencyProperty.Register(
                "IsToggled",
                typeof(bool),
                typeof(ToggleButton),
                new FrameworkPropertyMetadata(
                    false,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    OnIsToggledChanged));

        public bool IsToggled
        {
            get => (bool)GetValue(IsToggledProperty);
            set => SetValue(IsToggledProperty, value);
        }

        private static void OnIsToggledChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (ToggleButton)d;
            button.UpdateAppearance();
        }

        private void UpdateAppearance()
        {
            Background = IsToggled ? Brushes.Green : Brushes.Red;
            Content = IsToggled ? "ON" : "OFF";
        }

        public ToggleButton()
        {
            UpdateAppearance();
            Click += (sender, e) => IsToggled = !IsToggled;
        }
    }
}
