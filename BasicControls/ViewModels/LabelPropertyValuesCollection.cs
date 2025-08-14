using Feature.Infrastructure.Core;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace BasicControls.ViewModels
{
    internal class LabelPropertyValuesCollection : PropertyValuesCollection
    {

        [SetSourceForPropertyValues(typeof(System.Windows.FontWeights))]
        public ObservableCollection<System.Windows.FontWeight> FontWeightsCollection { get; private set; }


        [SetSourceForPropertyValues(typeof(System.Windows.Media.Colors))]
        public ObservableCollection<System.Windows.Media.Color> BorderBrushColorsCollection { get; private set; }

        //[SetSourceForPropertyValues(typeof(System.Windows.Media.FontFamily))]
        private ObservableCollection<FontFamily> fontFamiliesCollection;
        public ObservableCollection<System.Windows.Media.FontFamily> FontFamiliesCollection 
        {
            get 
            {
                if (fontFamiliesCollection == null)
                {
                    fontFamiliesCollection = new ObservableCollection<FontFamily>(Fonts.SystemFontFamilies);
                }
                return fontFamiliesCollection;
            }
        }
    }
}
