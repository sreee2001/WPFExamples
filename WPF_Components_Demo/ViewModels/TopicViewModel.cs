using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows;
using Feature.Infrastructure.Interfaces;

namespace WPF_Components_Demo
{
    public class TopicViewModel
    {
        public string Title { get; set; }

        public ObservableCollection<SubTopicViewModel> SubTopicViewModels { get; set; } = new ObservableCollection<SubTopicViewModel>();
        
        public bool IsExpanded { get; set; } = true;
        
        public TopicViewModel(IFeatureDemoTopic topic)
        {
            Title = topic.Title;
            foreach (var sub in topic.SubTopics)
            {
                SubTopicViewModel viewModel = new SubTopicViewModel(sub);
                ((App)Application.Current).Container.ComposeParts(viewModel);
                SubTopicViewModels.Add(viewModel);
            }
        }
    }
}
