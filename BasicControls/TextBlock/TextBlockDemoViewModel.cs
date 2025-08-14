using BasicControls.Resources;
using BasicControls.Topics;
using Feature.Infrastructure.AbstractImplementation;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows;

namespace BasicControls.TextBlock
{
    [Export(typeof(IDemonstrationViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.TextBlockControlTitle)]
    internal class TextBlockDemoViewModel : DemoViewModel<TextBlockProperties>
    {
        private PropertyValuesCollection propertyValuesCollection;

        [Import]
        public PropertyValuesCollection PropertyValuesCollection
        {
            get => propertyValuesCollection;
            set => SetField(ref propertyValuesCollection, value);
        }
        public TextBlockDemoViewModel()
        {
            //PropertyValuesCollection = new PropertyValuesCollection();
            PopulateTextBlockSamples();
        }

        private string _header;

        public string Header
        {
            get => _header;
            set => SetField(ref _header, value);
        }

        private void PopulateTextBlockSamples()
        {
            //Header = "TextBlock Control Demonstration";
            Header = "Different Label Styles in WPF";            

            // Initialize the collection with some sample data
            Samples = new ObservableCollection<TextBlockProperties>
            {
            new TextBlockProperties
                {
                    Text = "Sample Text 1",
                    FontFamily = new System.Windows.Media.FontFamily("Arial"),
                    FontSize = 12,
                    FontWeight = FontWeights.Normal,
                    Foreground = "Black",
                    Background = "White",
                    HorizontalAlignment = "Left",
                    VerticalAlignment = "Top",
                    // Assuming you have these properties in your class:
                    // Width = 200,
                    // Height = 50,
                    // BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black),
                    // Index = 0
                },
                new TextBlockProperties
                {
                    Text = "Sample Text 2",
                    FontFamily = new System.Windows.Media.FontFamily("Verdana"),
                    FontSize = 14,
                    FontWeight = FontWeights.Bold,
                    Foreground = "Blue",
                    Background = "LightGray",
                    HorizontalAlignment = "Center",
                    VerticalAlignment = "Center",
                    // Width = 250,
                    // Height = 60,
                    // BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black),
                    // Index = 1
                },
                new TextBlockProperties
                {
                    Text = "Sample Text 3",
                    FontFamily = new System.Windows.Media.FontFamily("Tahoma"),
                    FontSize = 16,
                    FontWeight = FontWeights.SemiBold,
                    Foreground = "Green",
                    Background = "Yellow",
                    HorizontalAlignment = "Right",
                    VerticalAlignment = "Bottom",
                    // Width = 300,
                    // Height = 70,
                    // BorderBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Orange),
                    // Index = 2
                }
            };
        }

    }
}
