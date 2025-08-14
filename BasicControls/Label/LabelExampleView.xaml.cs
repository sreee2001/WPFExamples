using System.Windows.Controls;

namespace BasicControls.Label
{
    /// <summary>
    /// Interaction logic for LabelExampleView.xaml
    /// </summary>
    public partial class LabelExampleView : UserControl
    {
        public LabelExampleView()
        {
            InitializeComponent();
            DataContext = new LabelExampleViewModel();
        }
    }
}
