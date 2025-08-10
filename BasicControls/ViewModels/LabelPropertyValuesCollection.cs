using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace BasicControls.ViewModels
{
    internal class LabelPropertyValuesCollection
    {
        public ObservableCollection<FontWeight> FontWeightsCollection { get; private set; }

        public LabelPropertyValuesCollection() 
        {
            // Get all FontWeight values
            FontWeightsCollection = GetStaticPropertyValues<FontWeight>(typeof(System.Windows.FontWeights));
        }

        private static ObservableCollection<T> GetStaticPropertyValues<T>(Type type)
        {
            IEnumerable<T> data =  type
                .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                .Where(p => p.PropertyType == typeof(T))
                .Select(p => (T)p.GetValue(null));
            return new ObservableCollection<T>(data);
        }
    }
}
