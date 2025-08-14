using BasicControls.Resources;
using BasicControls.Topics;
using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using Infrastructure.Base;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;

namespace BasicControls.Label
{
    [Export(typeof(IDemonstrationViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.LabelControlTitle)]
    internal class LabelDemoViewModel : DemoViewModel<LabelProperties>
    {
        private PropertyValuesCollection propertyValuesCollection;

        [Import]
        public PropertyValuesCollection PropertyValuesCollection
        {
            get => propertyValuesCollection;
            set => SetField(ref propertyValuesCollection , value);
        }

        public LabelDemoViewModel()
        {
            //PropertyValuesCollection = new PropertyValuesCollection();
            PopulateSamples();
        }

        private void PopulateSamples()
        {
            // Initialize the collection with some sample data
            Samples = new ObservableCollection<LabelProperties>
            {
                new LabelProperties("Sample Text 1", new System.Windows.Media.FontFamily("Arial"), 12, FontWeights.Normal, "Black", "White", "Left", "Top", 200, 50, new SolidColorBrush(Colors.Black), 0),
                new LabelProperties("Sample Text 2", new System.Windows.Media.FontFamily("Verdana"), 14, FontWeights.Bold, "Blue", "LightGray", "Center", "Center", 250, 60, new SolidColorBrush(Colors.Black), 1),
                new LabelProperties("Sample Text 3", new System.Windows.Media.FontFamily("Tahoma"), 16, FontWeights.SemiBold, "Green", "Yellow", "Right", "Bottom", 300, 70, new SolidColorBrush(Colors.Orange), 2)
            };
        }
    }
}
