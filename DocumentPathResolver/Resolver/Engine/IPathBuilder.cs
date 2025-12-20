
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Engine
{
    public interface IPathBuilder<T> where T : class
    {
        string Build(T input, IEnumerable<IPathSegmentProvider<T>> providers);

    }
}
