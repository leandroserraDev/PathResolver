using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Specification;


namespace DocumentPathResolver.Resolver.Engine.Person
{
    public class NamePathRules : PathRules<Entities.Person>
    {
        public NamePathRules(IPathSegmentProvider<Entities.Person> provider, ISpecification<Entities.Person> specification) : base(provider, specification)
        {
        }
    }
}
