using BasicControls.Topics;
using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.ComponentModel.Composition;

namespace BasicControls.TextBlock
{
    [Export(typeof(IIntroductionViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.TextBlockControlTitle)]
    internal class TextBlockIntroductionViewModel : IntroductionViewModel, IIntroductionViewModel
    {
        public override string Title => AddonMetadataKeys.TextBlockControlTitle;
    }

}
