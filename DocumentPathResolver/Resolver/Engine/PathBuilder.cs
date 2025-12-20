using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Engine
{
    public sealed class PathBuilder<T> : IPathBuilder<T> where T : class
    {

       
        public string Build(T model, IEnumerable<IPathSegmentProvider<T>> providers)
        {
            var segments = providers
                .SelectMany(p => p.GetSegments(model))
                .Where(s => !string.IsNullOrWhiteSpace(s));

            return string.Join("/", segments);
        }

    }
}
