using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows;

namespace WPF_Components_Demo.Views
{
    public partial class MainWindow : Window
    {
        private IEnumerable<ResourceDictionary> resourceDictionaries;

        [ImportMany(typeof(ResourceDictionary))]
        public IEnumerable<ResourceDictionary> ResourceDictionaries
        {
            get
            {
                return resourceDictionaries;
            }

            set
            {
                resourceDictionaries = value;

                foreach (var dict in ResourceDictionaries)
                {
                    if (dict != null)
                        Application.Current.Resources.MergedDictionaries.Add(dict);
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var viewModel = DataContext as MainWindowViewModel;
            if (viewModel != null && e.NewValue is SubTopicViewModel subTopicViewModel)
            {
                viewModel.SelectedSubTopicViewModel = subTopicViewModel;
                //subTopic.LaunchDemoCommand.Execute(null);
            }
        }
    }
}
