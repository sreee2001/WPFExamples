using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Interfaces;
using System.Collections.ObjectModel;

namespace BasicControls.Common
{
    internal abstract class ControlIntroductionViewModel : IntroductionViewModel, IIntroductionViewModel
    {
        public abstract string Header { get; }
        public abstract ObservableCollection<string> DescriptionCollection { get; }
        public abstract string SamplesIntroductionHeader { get; }
    }
}
