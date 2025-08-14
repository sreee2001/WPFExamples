using BasicControls.Topics;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;
using System.Windows.Controls;

namespace BasicControls.Views
{
    /// <summary>
    /// Interaction logic for LabelIntroductionView.xaml
    /// </summary>
    [Export(typeof(IIntroductionView))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.LabelControlTitle)]
    public partial class LabelIntroductionView : UserControl, IIntroductionView
    {
        public LabelIntroductionView()
        {
            InitializeComponent();
        }
    }
}
