using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace Feature.Infrastructure.Core
{
    public abstract class PropertyValuesCollection
    {
        public PropertyValuesCollection()
        {
            PopulateSourcePropertyValues();
        }

        private void PopulateSourcePropertyValues()
        {
            // Get all properties of the current instance that have the SetSourceForPropertyValuesAttribute
            var props = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Iterate through each property and populate it with static values from the specified source type
            foreach (var prop in props)
            {
                // Check if the property has the SetSourceForPropertyValuesAttribute
                var attr = prop.GetCustomAttributes(typeof(SetSourceForPropertyValuesAttribute), false).FirstOrDefault() as SetSourceForPropertyValuesAttribute;

                // If the attribute is found, retrieve the static values from the source type
                if (attr != null)
                {
                    // Get the generic type of the property (e.g., ObservableCollection<T>)
                    var genericType = prop.PropertyType.GetGenericArguments().FirstOrDefault();
                    var values = attr.SourceType
                        .GetProperties(BindingFlags.Public | BindingFlags.Static)
                        .Where(p => p.PropertyType == genericType)
                        .Select(p => p.GetValue(null))
                        .ToList();

                    // Create a typed list and populate it with the static values
                    var typedList = Activator.CreateInstance(typeof(List<>).MakeGenericType(genericType));
                    // Use reflection to get the Add method of the typed list
                    var addMethod = typedList.GetType().GetMethod("Add");
                    // Invoke the Add method for each value to populate the list
                    foreach (var value in values)
                    {
                        addMethod.Invoke(typedList, new[] { value });
                    }

                    // Create an ObservableCollection from the typed list and set it to the property
                    var collectionType = typeof(ObservableCollection<>).MakeGenericType(genericType);
                    // Use reflection to create an instance of the ObservableCollection with the typed list
                    var collection = Activator.CreateInstance(collectionType, new object[] { typedList });

                    // Set the property value to the newly created collection
                    prop.SetValue(this, collection);
                }
            }
        }
    }
}
