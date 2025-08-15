using BasicControls.Common;
using BasicControls.Topics;
using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;

namespace BasicControls.TextBlock
{
    [Export(typeof(IIntroductionViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.TextBlockControlTitle)]
    internal class TextBlockIntroductionViewModel : ControlIntroductionViewModel, IIntroductionViewModel
    {
        public override string Title => AddonMetadataKeys.TextBlockControlTitle;
        public override string Header => Title;

        public override ObservableCollection<string> DescriptionCollection { get; } = new ObservableCollection<string>
        {
            "The TextBlock control is used to display a small amount of text in the user interface.",
            "It is lightweight and optimized for performance, making it suitable for displaying text in WPF applications.",
            "TextBlock supports various text formatting options, such as font size, font weight, and text alignment.",
            "It can also handle text wrapping and text trimming, allowing for flexible text display in different layouts.",
            "TextBlock is often used in scenarios where you need to display static text or simple text content without the overhead of a full-fledged TextBox control.",
            "It can be used in data binding scenarios to display text from a data source, making it a powerful tool for creating dynamic user interfaces.",
            "TextBlock can also be styled and templated to match the visual design of your application, providing a consistent look and feel across different controls.",
            "In summary, TextBlock is a versatile control for displaying text in WPF applications, offering performance and flexibility for various text display scenarios."

        };

        public override string SamplesIntroductionHeader => "Few Samples of TextBox are provided below";
    }

}
