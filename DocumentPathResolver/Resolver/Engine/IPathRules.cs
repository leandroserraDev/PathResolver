using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Specification;
namespace DocumentPathResolver.Resolver.Engine
{
    public interface IPathRules<T> where T : class
    {
        IPathSegmentProvider<T> Provider { get; }
        ISpecification<T> Specification { get; }
        public int Order { get; }

    }
}
