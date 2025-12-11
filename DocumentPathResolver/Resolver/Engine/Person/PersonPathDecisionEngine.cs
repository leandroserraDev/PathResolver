using DocumentPathResolver.Resolver.Provider;
using DocumentPathResolver.Resolver.Provider.Person;
using DocumentPathResolver.Resolver.Specification;
using DocumentPathResolver.Resolver.Specification.Age;
using DocumentPathResolver.Resolver.Specification.Document;
using DocumentPathResolver.Resolver.Specification.LastName;
using DocumentPathResolver.Resolver.Specification.Name;

namespace DocumentPathResolver.Resolver.Engine.Person
{
    public class PersonPathDecisionEngine : PathDecisionEngine<Entities.Person>, IPersonPathDecisionEngine
    {
        private readonly INameSpecification _nameSpecification;
        private readonly ILastNameSpecification _lastNameSpecification;
        private readonly IAgeSpecification _ageSpecification;
        private readonly IDocumentSpecification _documentSpecification;


        public PersonPathDecisionEngine(INameSpecification nameSpecification, 
            ILastNameSpecification lastNameSpecification, IAgeSpecification ageSpecification, 
            IDocumentSpecification documentSpecification)
        {
            _nameSpecification=nameSpecification;
            _lastNameSpecification=lastNameSpecification;
            _ageSpecification=ageSpecification;
            _documentSpecification=documentSpecification;
        }

        public override IEnumerable<IPathSegmentProvider<Entities.Person>> DecideProviders(Entities.Person candidate)
        {

            var mapping = new (ISpecification<Entities.Person> Spec, IPathSegmentProvider<Entities.Person> Provider)[]
             {
                    (_nameSpecification, new NameSegmentProvider()),
                    (_lastNameSpecification, new LastNameSegmentProvider()),
                    (_ageSpecification, new AgeSegmentProvider()),
                    (_documentSpecification, new DocumentSegmentProvider())
             };

            foreach (var (spec, provider) in mapping)
            {
                if (spec.IsSatisfiedBy(candidate))
                    yield return provider;
            }
        }
    }
}
