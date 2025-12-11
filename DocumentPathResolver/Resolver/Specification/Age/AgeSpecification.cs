using DocumentPathResolver.Entities;

namespace DocumentPathResolver.Resolver.Specification.Age
{
    public class AgeSpecification : IAgeSpecification
    {
        public bool IsSatisfiedBy(Person candidate)
        {
            // retorna a idade se for igual/maior que 16.

            return candidate.Age >=16;
        }
    }
}
