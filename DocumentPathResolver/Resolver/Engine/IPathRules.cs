using DocumentPathResolver.Resolver.Provider;
namespace DocumentPathResolver.Resolver.Engine
{
    public interface IPathRules<T> where T : class
    {
        bool IsMatch(T candidate);
        IPathSegmentProvider<T> Provider { get; }
    }
}
