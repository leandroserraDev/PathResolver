
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Engine
{
    public class PathDecisionEngine<T> : IPathDecisionEngine<T>
        where T : class
    {
        public virtual IEnumerable<IPathSegmentProvider<T>> DecideProviders(T candidate)
        {
            throw new NotImplementedException();
        }
    }
}
