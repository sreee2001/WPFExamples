using Feature.Infrastructure.Core;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows.Media;

namespace BasicControls.Resources
{
    /// <summary>
    /// Represents a collection of property values used for UI customization, such as font weights, border brush colors,
    /// and font families.
    /// </summary>
    /// <remarks>This class provides collections of commonly used property values for UI elements, such as
    /// font weights, colors, and font families. The collections are initialized based on predefined sources or system
    /// resources.</remarks>
    [Export]
    public class PropertyValuesCollection : PropertyValuesCollectionBase
    {
        /// <summary>
        /// Gets the collection of font weights available for use.
        /// </summary>
        /// <remarks>The collection is initialized with font weights sourced from <see
        /// cref="System.Windows.FontWeights"/>. This property is read-only and cannot be modified directly.</remarks>
        [SetSourceForPropertyValues(typeof(System.Windows.FontWeights))]
        public ObservableCollection<System.Windows.FontWeight> FontWeightsCollection { get; private set; }

        /// <summary>
        /// Gets the collection of colors available for use as border brush options.
        /// </summary>
        /// <remarks>This collection is initialized with a predefined set of colors sourced from the <see
        /// cref="Colors"/> class. The collection is read-only and cannot be modified directly.</remarks>
        [SetSourceForPropertyValues(typeof(Colors))]
        public ObservableCollection<Color> BorderBrushColorsCollection { get; private set; }

        /// <summary>
        /// Represents a collection of font families available for use in the application.
        /// </summary>
        /// <remarks>This collection is intended to store instances of <see
        /// cref="System.Windows.Media.FontFamily"/>  and can be used to populate font selection controls or manage
        /// font-related functionality.</remarks>
        //[SetSourceForPropertyValues(typeof(System.Windows.Media.FontFamily))]
        private ObservableCollection<FontFamily> fontFamiliesCollection;
        public ObservableCollection<FontFamily> FontFamiliesCollection 
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
