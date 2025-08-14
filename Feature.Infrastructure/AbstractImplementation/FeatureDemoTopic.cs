using Feature.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace Feature.Infrastructure.AbstractImplementation
{
    public abstract class FeatureDemoTopic : IFeatureDemoTopic
    {
        public abstract string Title { get; }
        
        [ImportMany]
        public IEnumerable<Lazy<IFeatureDemoSubTopic, IHaveTopicName>> AllSubTopics { get; set; }

        public IEnumerable<IFeatureDemoSubTopic> SubTopics =>
            AllSubTopics.Where(x => x.Metadata.TopicName == Title).Select(x => x.Value);
    }
}
