using DocumentPathResolver.Entities;
using DocumentPathResolver.Resolver.Provider;

namespace DocumentPathResolver.Resolver.Specification.Document
{
    public class DocumentSpecification
    {
        public IPathSegmentProvider<Entities.Person> IsSatisfiedBy(Person candidate)
        {
            // retorna documento se for igual/maior 18

            return null!;
        }
    }
}
