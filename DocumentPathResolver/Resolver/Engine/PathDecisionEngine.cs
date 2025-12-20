
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Engine
{
    public class PathDecisionEngine<T> : IPathDecisionEngine<T>
        where T : class
    {
        public readonly IEnumerable<IPathRules<T>> _pathRules;

        public PathDecisionEngine(IEnumerable<IPathRules<T>> pathRules)
        {
            _pathRules =pathRules;
        }

        public virtual IEnumerable<IPathSegmentProvider<T>> DecideProviders(T candidate)
        {
            foreach (var pathRule in _pathRules)
            {

                if (pathRule.IsMatch(candidate))
                {
                    yield return pathRule.Provider;
                }

            }
        }


    }
}
