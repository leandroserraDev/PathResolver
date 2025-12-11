using DocumentPathResolver.Entities;

namespace DocumentPathResolver.Resolver.Specification.Name
{
    public class NameSpecification : INameSpecification
    {
        public bool IsSatisfiedBy(Person candidate)
        {
            //Sempre retorna o nome

            return true;
        }
    }
}
