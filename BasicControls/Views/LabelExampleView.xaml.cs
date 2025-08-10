using System.Windows;

namespace BasicControls.Views
{
    /// <summary>
    /// Interaction logic for LabelExampleView.xaml
    /// </summary>
    public partial class LabelExampleView : Window
    {
        public LabelExampleView()
        {
            InitializeComponent();
            DataContext = new ViewModels.LabelExampleViewModel();
        }
    }
}
