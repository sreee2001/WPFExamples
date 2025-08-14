using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Topics
{
    [Export(typeof(IFeatureDemoTopic))]
    public class BasicControls : FeatureDemoTopic
    {
        public override string Title => AddonMetadataKeys.BasicControlsTitle;
    }
}
