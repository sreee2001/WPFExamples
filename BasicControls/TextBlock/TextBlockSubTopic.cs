using BasicControls.Topics;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.TextBlock
{
    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, AddonMetadataKeys.BasicControlsTitle)]
    public class TextBlockSubTopic : IFeatureDemoSubTopic
    {
        public string Title => AddonMetadataKeys.TextBlockControlTitle;
    }
}
