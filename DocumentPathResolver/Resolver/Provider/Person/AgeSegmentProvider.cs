
namespace DocumentPathResolver.Resolver.Provider.Person
{
    public class AgeSegmentProvider : IAgeSegmentProvider
    {
        public IEnumerable<string> GetSegments(Entities.Person candidate)
        {
           yield return candidate.Age.ToString();
        }
    }
}
