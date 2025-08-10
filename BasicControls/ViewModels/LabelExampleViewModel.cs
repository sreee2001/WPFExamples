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
                new LabelExample("Sample Text 1", "Arial", 12, true, false, false, false),
                new LabelExample("Sample Text 2", "Times New Roman", 14, false, true, true, false),
                new LabelExample("Sample Text 3", "Courier New", 16, true, true, false, true),
                new LabelExample("Sample Text 4", "Verdana", 18, false, false, true, false)
            };
        }
    }
}
