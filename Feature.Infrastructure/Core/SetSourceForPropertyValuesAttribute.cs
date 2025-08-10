using System;

namespace Feature.Infrastructure.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SetSourceForPropertyValuesAttribute : Attribute
    {
        public Type SourceType { get; }
        public SetSourceForPropertyValuesAttribute(Type sourceType)
        {
            SourceType = sourceType;
        }
    }
}
