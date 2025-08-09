using Feature.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature.Infrastructure.AbstractImplementation
{
    public abstract class FeatureDemoTopic : IFeatureDemoTopic
    {
        public abstract string Title { get; }
        
        [ImportMany]
        public IEnumerable<Lazy<IFeatureDemoSubTopic, ISubTopicMetadata>> AllSubTopics { get; set; }

        public IEnumerable<IFeatureDemoSubTopic> SubTopics =>
            AllSubTopics.Where(x => x.Metadata.TopicName == Title).Select(x => x.Value);
    }
}
