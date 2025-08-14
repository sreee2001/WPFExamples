using BasicControls.Topics;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Label
{
    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, AddonMetadataKeys.BasicControlsTitle)]
    public class LabelSubTopic : IFeatureDemoSubTopic
    {
        public string Title => AddonMetadataKeys.LabelControlTitle;
    }
}
