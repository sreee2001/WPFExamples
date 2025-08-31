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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicControls.PhaseTwo.Topics.SampleViews
{
    /// <summary>
    /// Interaction logic for PasswordBoxSampleView.xaml
    /// </summary>
    public partial class PasswordBoxSampleView : UserControl
    {
        public PasswordBoxSampleView()
        {
            InitializeComponent();
        }

        private void PasswordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordPlaceholder.Visibility = string.IsNullOrEmpty(passwordBox1.Password)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
        // For Show/Hide Password (example logic)
        private void ShowPassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(passwordBox2.Password, "Password");
        }

        // For Validation
        private void PasswordBox3_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pb = sender as PasswordBox;
            pb.BorderBrush = (pb.Password.Length < 8) ? Brushes.Red : Brushes.Green;
        }

        // For Caps Lock Warning
        private void PasswordBox4_PasswordChanged(object sender, RoutedEventArgs e)
        {
            capsLockWarning.Visibility = Console.CapsLock ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
