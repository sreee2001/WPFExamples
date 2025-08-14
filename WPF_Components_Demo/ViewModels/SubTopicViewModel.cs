using System.Windows.Input;
using Feature.Infrastructure.Interfaces;

namespace WPF_Components_Demo
{
    public class SubTopicViewModel
    {
        public string Title { get; set; }
        public IFeatureDemoSubTopic SubTopic { get; set; }
        public ICommand LaunchDemoCommand { get; set; }
        public bool IsExpanded { get; set; } = true;
        public SubTopicViewModel(IFeatureDemoSubTopic subTopic)
        {
            Title = subTopic.Title;
            SubTopic = subTopic;
            LaunchDemoCommand = new RelayCommand(_ => SubTopic.LaunchDemoWindow());
        }
    }
}
