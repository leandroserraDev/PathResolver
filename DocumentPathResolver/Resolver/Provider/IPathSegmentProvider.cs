namespace DocumentPathResolver.Resolver.Provider
{
    public interface IPathSegmentProvider<T> where T : class
    {
        IEnumerable<string> GetSegments(T candidate);
    }
}
