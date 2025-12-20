using DocumentPathResolver.Entities;

namespace DocumentPathResolver.Resolver.Specification.Age
{
    public class AgeSpecification : IAgeSpecification
    {
        public bool IsSatisfiedBy(Person candidate)
        {
            return candidate.Age >= 20;
        }
    }
}
