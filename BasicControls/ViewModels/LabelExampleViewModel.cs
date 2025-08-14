using BasicControls.Models;
using Infrastructure.Base;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace BasicControls.ViewModels
{
    internal class LabelExampleViewModel : PropertyChangedBase
    {
        private ObservableCollection<LabelExample> labelSamples;
        private LabelPropertyValuesCollection propertyValuesCollection;

        public ObservableCollection<LabelExample> LabelSamples 
        {
            get => labelSamples;
            set => SetField(ref labelSamples, value); 
        }

        public LabelPropertyValuesCollection PropertyValuesCollection
        {
            get => propertyValuesCollection;
            set => SetField(ref propertyValuesCollection , value);
        }

        public LabelExampleViewModel()
        {
            LabelSamples = new ObservableCollection<LabelExample>();
            PropertyValuesCollection = new LabelPropertyValuesCollection();


            PopulateLabelSamples();
        }

        private void PopulateLabelSamples()
        {
            // Initialize the collection with some sample data
            LabelSamples = new ObservableCollection<LabelExample>
            {
                new LabelExample("Sample Text 1", new System.Windows.Media.FontFamily("Arial"), 12, FontWeights.Normal, "Black", "White", "Left", "Top", 200, 50, new SolidColorBrush(Colors.Black), 0),
                new LabelExample("Sample Text 2", new System.Windows.Media.FontFamily("Verdana"), 14, FontWeights.Bold, "Blue", "LightGray", "Center", "Center", 250, 60, new SolidColorBrush(Colors.Black), 1),
                new LabelExample("Sample Text 3", new System.Windows.Media.FontFamily("Tahoma"), 16, FontWeights.SemiBold, "Green", "Yellow", "Right", "Bottom", 300, 70, new SolidColorBrush(Colors.Orange), 2)
            };
        }
    }
}
