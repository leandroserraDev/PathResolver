using DocumentPathResolver.Entities;
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Specification.Name
{
    public class NameSpecification : INameSpecification
    {
        public bool IsSatisfiedBy(Person candidate)
        {
            return true;
        }
    }
}
