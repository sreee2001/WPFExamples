using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Topics
{
    [Export(typeof(IFeatureDemoSubTopic))]
    [ExportMetadata(MetaDataKeys.TopicName, BasicControlMetaDataKeys.Title)]
    public class LabelSubTopic : IFeatureDemoSubTopic
    {
        public string Title => "Label Samples";
        public void LaunchDemoWindow()
        {
            // Logic to launch Label demo window
            var labelExampleView = new Views.LabelExampleView();
            labelExampleView.ShowDialog();
        }
        public IIntroductionView GetIntroductionView()
        {
            // Logic to set the introduction page for Label samples
            var introductionView = new Views.LabelIntroductionView();
            return introductionView;
        }
    }
}
