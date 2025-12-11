namespace DocumentPathResolver.Resolver.Engine
{
    public interface IFilePathOrchestrator<T> where T : class
    {
        string BuildFilePath(T candidate);
    }
}
