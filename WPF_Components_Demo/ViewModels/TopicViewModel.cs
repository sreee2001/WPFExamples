using System.Collections.ObjectModel;
using Feature.Infrastructure.Interfaces;

namespace WPF_Components_Demo
{
    public class TopicViewModel
    {
        public string Title { get; set; }
        public ObservableCollection<SubTopicViewModel> SubTopics { get; set; } = new ObservableCollection<SubTopicViewModel>();
        public bool IsExpanded { get; set; } = true;
        public TopicViewModel(IFeatureDemoTopic topic)
        {
            Title = topic.Title;
            foreach (var sub in topic.SubTopics)
            {
                SubTopics.Add(new SubTopicViewModel(sub));
            }
        }
    }
}
