using Infrastructure.Base;

namespace BasicControls.ViewModels
{
    internal class LabelIntroductionViewModel : PropertyChangedBase
    {
        private LabelExampleViewModel labelExampleViewModel;
        public LabelExampleViewModel LabelExampleViewModel
        {
            get => labelExampleViewModel;
            set => SetField(ref labelExampleViewModel, value);
        }
        public LabelIntroductionViewModel()
        {
            LabelExampleViewModel = new LabelExampleViewModel();
        }
    }
}
