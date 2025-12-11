using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Engine
{
    public sealed class PathBuilder<T> : IPathBuilder<T> where T : class
    {
        private readonly List<IPathSegmentProvider<T>> _providers = new List<IPathSegmentProvider<T>>();

        public void AddProvider(IPathSegmentProvider<T> p)
        {
            _providers.Add(p);
        }

        public string Build(T model)
        {
            var segments = _providers
                .SelectMany(p => p.GetSegments(model))
                .Where(s => !string.IsNullOrWhiteSpace(s));

            return string.Join("/", segments);
        }
    }
}
