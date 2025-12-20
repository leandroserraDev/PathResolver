
using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Specification;

namespace DocumentPathResolver.Resolver.Engine
{
    public class PathRules<T> : IPathRules<T> where T : class
    {
        private readonly ISpecification<T> _specification;
        public IPathSegmentProvider<T> Provider { get; }


        public PathRules(IPathSegmentProvider<T> provider,
            ISpecification<T> specification)
        {
            Provider=provider;
            _specification=specification;
        }

        public bool IsMatch(T candidate) => _specification.IsSatisfiedBy(candidate);
    }
}
