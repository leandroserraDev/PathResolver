using DocumentPathResolver.Entities;
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Specification.LastName
{
    public class LastNameSpecification 
    {
        public IPathSegmentProvider<Entities.Person> IsSatisfiedBy(Person candidate)
        {
            //Adicionar ultimo nome se for igual/maior de 18 anos.

            return null!;
        }
    }
}
