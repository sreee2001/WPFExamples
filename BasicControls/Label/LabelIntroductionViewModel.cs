using BasicControls.Common;
using BasicControls.Topics;
using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;

namespace BasicControls.Label
{
    [Export(typeof(IIntroductionViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.LabelControlTitle)]
    internal class LabelIntroductionViewModel : ControlIntroductionViewModel, IIntroductionViewModel
    {
        public override string Title => AddonMetadataKeys.LabelControlTitle;

        public override string Header => Title;

        public override ObservableCollection<string> DescriptionCollection { get; } = new ObservableCollection<string>
        {
            "Label controls usually provide information in the user interface (UI).",
            "Historically, a Label has contained only text, but because the Label that ships with Windows Presentation Foundation (WPF) is a ContentControl, it can contain either text or a UIElement.",
            "The Label control is a versatile control that can display text, images, or other UI elements. It is commonly used to provide descriptive text for other controls, such as TextBox or ComboBox."
        };

        public override string SamplesIntroductionHeader => "Few Samples of Labels are provided below";
    }
}
