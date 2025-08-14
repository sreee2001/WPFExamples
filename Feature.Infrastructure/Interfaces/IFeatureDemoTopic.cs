using System.Collections.Generic;

namespace Feature.Infrastructure.Interfaces
{
    public interface IFeatureDemoTopic : IHaveTitle
    {
        IEnumerable<IFeatureDemoSubTopic> SubTopics { get; }
    }
}
