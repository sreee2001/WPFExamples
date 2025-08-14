using BasicControls.Topics;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;
using System.Windows;

namespace BasicControls.Views
{
    /// <summary>
    /// Interaction logic for LabelExampleView.xaml
    /// </summary>
    [Export(typeof(IDemonstrationView))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.LabelControlTitle)]
    public partial class LabelExampleView : Window, IDemonstrationView
    {
        public LabelExampleView()
        {
            InitializeComponent();
            DataContext = new ViewModels.LabelExampleViewModel();
        }
    }
}
