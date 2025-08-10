using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls
{
    public class BasicControlMetaDataKeys
    {
        public const string Title = "Basic Controls";
    }

    [Export(typeof(IFeatureDemoTopic))]
    public class BasicControls : FeatureDemoTopic
    {
        public override string Title => BasicControlMetaDataKeys.Title;
    }

    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, BasicControlMetaDataKeys.Title)]
    public class TextBlockSubTopic : IFeatureDemoSubTopic
    {
        public string Title => "TextBlock Samples";
        public void LaunchDemoWindow()
        {
            // Logic to launch TextBlock demo window
        }
    }

    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, BasicControlMetaDataKeys.Title)]
    public class LabelSubTopic : IFeatureDemoSubTopic
    {
        public string Title => "Label Samples";
        public void LaunchDemoWindow()
        {
            // Logic to launch Label demo window
        }
    }
}
