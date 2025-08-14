using Feature.Infrastructure.Interfaces;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature.Infrastructure.AbstractImplementation
{
    public abstract class DemoViewModel<T> : PropertyChangedBase, IDemonstrationViewModel where T : class
    {
        private ObservableCollection<T> samples;

        public ObservableCollection<T> Samples 
        {
            get => samples;
            set => SetField(ref samples, value); 
        }
    }
}
