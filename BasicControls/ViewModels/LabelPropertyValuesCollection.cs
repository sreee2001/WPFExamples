using Feature.Infrastructure.Core;
using System.Collections.ObjectModel;

namespace BasicControls.ViewModels
{
    internal class LabelPropertyValuesCollection : PropertyValuesCollection
    {
        [SetSourceForPropertyValues(typeof(System.Windows.FontWeights))]
        public ObservableCollection<System.Windows.FontWeight> FontWeightsCollection { get; private set; }

    }
}
