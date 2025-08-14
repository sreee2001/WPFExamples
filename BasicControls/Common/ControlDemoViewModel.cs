using BasicControls.Resources;
using Feature.Infrastructure.AbstractImplementation;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicControls.Common
{
    internal class ControlDemoViewModel<T> : DemoViewModel<T> where T : class
    {
        private PropertyValuesCollection propertyValuesCollection;

        [Import]
        public PropertyValuesCollection PropertyValuesCollection
        {
            get => propertyValuesCollection;
            set => SetField(ref propertyValuesCollection, value);
        }

        private string _header;

        public string Header
        {
            get => _header;
            set => SetField(ref _header, value);
        }

    }
}
