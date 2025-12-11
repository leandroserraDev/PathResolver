
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Engine
{
    public interface IPathDecisionEngine<T> where T : class
    {

        IEnumerable<IPathSegmentProvider<T>> DecideProviders(T candidate);
    }
}
