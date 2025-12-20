using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Specification.Age;

namespace DocumentPathResolver.Resolver.Engine.Person
{
    public class AgePathRules : PathRules<Entities.Person>
    {
        public AgePathRules(IAgeSpecification ageSpecification, IPathSegmentProvider<Entities.Person> provider)
            :base(provider,ageSpecification)
        {
        }
    
    }
}
