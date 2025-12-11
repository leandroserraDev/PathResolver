using DocumentPathResolver.Entities;

namespace DocumentPathResolver.Resolver.Specification.LastName
{
    public class LastNameSpecification : ILastNameSpecification
    {
        public bool IsSatisfiedBy(Person candidate)
        {
            //Adicionar ultimo nome se for igual/maior de 18 anos.

            return candidate.Age >= 18;
        }
    }
}
