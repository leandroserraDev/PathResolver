
using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Specification;

namespace DocumentPathResolver.Resolver.Engine
{
    public class PathRules<T> : IPathRules<T> where T : class
    {
        public ISpecification<T> Specification { get; }
        public IPathSegmentProvider<T> Provider { get; }

        public int Order { get; }

        public PathRules(IPathSegmentProvider<T> provider,
            ISpecification<T> specification,
            int order)
        {
            Provider=provider;
            Specification=specification;
            Order=order;
        }

    }
}
