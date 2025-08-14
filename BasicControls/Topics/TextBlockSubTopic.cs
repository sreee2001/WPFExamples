using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Topics
{
    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, AddonMetadataKeys.BasicControlsTitle)]
    public class TextBlockSubTopic : IFeatureDemoSubTopic
    {
        public string Title => AddonMetadataKeys.TextBlockControlTitle;

        public void LaunchDemoWindow()
        {
            // Logic to launch TextBlock demo window
        }
    }
}
