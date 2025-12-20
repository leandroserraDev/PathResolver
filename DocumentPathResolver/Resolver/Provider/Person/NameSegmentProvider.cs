namespace DocumentPathResolver.Resolver.Provider.Person
{
    public class NameSegmentProvider : INameSegmentProvider
    {
        public IEnumerable<string> GetSegments(Entities.Person candidate)
        {
           yield return candidate.Name;
        }
    }
}
