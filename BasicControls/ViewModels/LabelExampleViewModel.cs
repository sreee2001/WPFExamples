using BasicControls.Models;
using Infrastructure.Base;
using System.Collections.ObjectModel;
using System.Windows;

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
                new LabelExample("Sample Text 1", "Arial", 12, FontWeights.Normal, "Black", "White", "Left", "Top", 200, 50),
                new LabelExample("Sample Text 2", "Verdana", 14, FontWeights.Bold, "Blue", "LightGray", "Center", "Center", 250, 60),
                new LabelExample("Sample Text 3", "Tahoma", 16, FontWeights.SemiBold, "Green", "Yellow", "Right", "Bottom", 300, 70)
            };
        }
    }
}
