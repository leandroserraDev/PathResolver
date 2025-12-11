namespace DocumentPathResolver.Resolver.Provider.Person
{
    public class NameSegmentProvider : IPathSegmentProvider<Entities.Person>
    {
        public IEnumerable<string> GetSegments(Entities.Person candidate)
        {
           yield return candidate.Name;
        }
    }
}
