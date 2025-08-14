using BasicControls.Topics;
using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.Label
{
    [Export(typeof(IIntroductionViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.LabelControlTitle)]
    internal class LabelIntroductionViewModel : IntroductionViewModel, IIntroductionViewModel
    {
        public override string Title => AddonMetadataKeys.LabelControlTitle;
    }
}
