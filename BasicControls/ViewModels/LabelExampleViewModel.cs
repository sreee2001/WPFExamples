using BasicControls.Models;
using Infrastructure.Base;
using System.Collections.ObjectModel;

namespace BasicControls.ViewModels
{
    internal class LabelExampleViewModel : PropertyChangedBase
    {
        private ObservableCollection<LabelExample> labelSamples;

        public ObservableCollection<LabelExample> LabelSamples 
        {
            get => labelSamples;
            set => SetField(ref labelSamples, value); 
        }

        public LabelExampleViewModel()
        {
            // Initialize the LabelSamples collection
            LabelSamples = new ObservableCollection<LabelExample>();
            PopulateLabelSamples();
        }

        private void PopulateLabelSamples()
        {
            // Initialize the collection with some sample data
            LabelSamples = new ObservableCollection<LabelExample>
            {
                new LabelExample("Sample Text 1", "Arial", 12, "Normal", "Black", "White", "Left", "Top", 200, 50),
                new LabelExample("Sample Text 2", "Verdana", 14, "Bold", "Blue", "LightGray", "Center", "Center", 250, 60),
                new LabelExample("Sample Text 3", "Tahoma", 16, "Italic", "Green", "Yellow", "Right", "Bottom", 300, 70)
            };
        }
    }
}
