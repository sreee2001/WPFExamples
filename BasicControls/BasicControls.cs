using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace BasicControls
{
    [Export(typeof(IFeatureDemoTopic))]
    public class BasicControls : FeatureDemoTopic
    {
        public override string Title => "BasicControls";
    }

    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata("TopicName", "BasicControls")]
    public class TextBlockSubTopic : IFeatureDemoSubTopic
    {
        public string Title => "TextBlock";
        public void LaunchDemoWindow()
        {
            // Logic to launch TextBlock demo window
        }
    }

    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata("TopicName", "BasicControls")]
    public class LabelSubTopic : IFeatureDemoSubTopic
    {
        public string Title => "Label";
        public void LaunchDemoWindow()
        {
            // Logic to launch Label demo window
        }
    }
}
