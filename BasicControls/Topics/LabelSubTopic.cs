using BasicControls.Views;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Topics
{
    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, AddonMetadataKeys.BasicControlsTitle)]
    public class LabelSubTopic : IFeatureDemoSubTopic
    {
        public string Title => AddonMetadataKeys.LabelControlTitle;

        public void LaunchDemoWindow()
        {
            // Logic to launch Label demo window
            var labelExampleView = new LabelExampleView();
            labelExampleView.ShowDialog();
        }
    }
}
