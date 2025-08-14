using System.ComponentModel.Composition;
using System.Windows;

namespace BasicControls.Views
{
    [Export(typeof(ResourceDictionary))]
    [ExportMetadata("DictionaryName", "DataTemplates")]
    public class LabelTemplatesResourceDictionary : ResourceDictionary
    {
        public LabelTemplatesResourceDictionary()
        {
            Source = new System.Uri("/BasicControls;component/Views/DataTemplates.xaml", System.UriKind.RelativeOrAbsolute);
        }
    }
}