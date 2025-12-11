
namespace DocumentPathResolver.Resolver.Provider.Person
{
    public class LastNameSegmentProvider : IPathSegmentProvider<Entities.Person>
    {
        public IEnumerable<string> GetSegments(Entities.Person candidate)
        {
            yield return candidate.LastName;
        }
    }
}
