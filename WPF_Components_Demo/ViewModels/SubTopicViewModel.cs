using System;
using Feature.Infrastructure.Interfaces;

namespace WPF_Components_Demo
{
    public class SubTopicViewModel : IHaveTitle
    {
        public string Title { get; set; }

        public IFeatureDemoSubTopic SubTopic { get; set; }

        public bool IsExpanded { get; set; } = true;

        public SubTopicViewModel(IFeatureDemoSubTopic subTopic)
        {
            if (subTopic == null)
            {
                throw new ArgumentNullException(nameof(subTopic), "SubTopic cannot be null");
            }
            Title = subTopic.Title;
            SubTopic = subTopic;
        }

    }
}
