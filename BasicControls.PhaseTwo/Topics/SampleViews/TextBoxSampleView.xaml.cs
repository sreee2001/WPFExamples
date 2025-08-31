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
    /// Interaction logic for TextBoxSampleView.xaml
    /// </summary>
    public partial class TextBoxSampleView : UserControl
    {
        public TextBoxSampleView()
        {
            InitializeComponent();
        }

        // For number-only TextBox
        private void NumberOnlyTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !e.Text.All(char.IsDigit);
        }

        // For character counter
        private void CounterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            charCountTextBlock.Text = $"{counterTextBox.Text.Length}/20";
        }
    }
}
