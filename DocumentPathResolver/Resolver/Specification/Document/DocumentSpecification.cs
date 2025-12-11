using DocumentPathResolver.Entities;

namespace DocumentPathResolver.Resolver.Specification.Document
{
    public class DocumentSpecification : IDocumentSpecification
    {
        public bool IsSatisfiedBy(Person candidate)
        {
            // retorna documento se for igual/maior 18

            return candidate.Age >=18;
        }
    }
}
