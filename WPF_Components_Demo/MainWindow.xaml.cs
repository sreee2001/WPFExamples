using Feature.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Components_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [ImportMany]
        public IEnumerable<IFeatureDemoTopic> Topics { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadTopics();
        }

        private void LoadTopics()
        {
            var catalog = new DirectoryCatalog(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FeaturesDemo"));
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            foreach (var topic in Topics)
            {
                // Satisfy imports for subtopics in each topic
                container.SatisfyImportsOnce(topic);

                var topicItem = new TreeViewItem { Header = topic.Title, DataContext = topic };
                foreach (var subtopic in topic.SubTopics)
                {
                    var subtopicItem = new TreeViewItem { Header = subtopic.Title, DataContext = subtopic };
                    topicItem.Items.Add(subtopicItem);
                }
                TopicsTreeView.Items.Add(topicItem);
            }
        }
        private void TopicsTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var selectedItem = TopicsTreeView.SelectedItem as TreeViewItem;
            if (selectedItem?.DataContext is IFeatureDemoSubTopic subtopic)
            {
                subtopic.LaunchDemoWindow();
            }
        }
    }
}
