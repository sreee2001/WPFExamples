using System.Collections.Generic;

namespace Feature.Infrastructure.Interfaces
{
    public interface IFeatureDemoTopic
    {
        string Title { get; }
        IEnumerable<IFeatureDemoSubTopic> SubTopics { get; }
    }
}
