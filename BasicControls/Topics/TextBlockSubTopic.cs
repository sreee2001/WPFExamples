using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Topics
{
    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, BasicControlMetaDataKeys.Title)]
    public class TextBlockSubTopic : IFeatureDemoSubTopic
    {
        public string Title => "TextBlock Samples";
        public void LaunchDemoWindow()
        {
            // Logic to launch TextBlock demo window
        }
        public IIntroductionView GetIntroductionView()
        {
            // Logic to get the introduction page for TextBlock samples
            return null;
        }
    }
}
