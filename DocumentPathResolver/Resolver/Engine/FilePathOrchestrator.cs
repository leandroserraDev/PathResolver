
namespace DocumentPathResolver.Resolver.Engine
{
    public class FilePathOrchestrator<T> : IFilePathOrchestrator<T> where T : class
    {
        private readonly IPathDecisionEngine<T> _decisionEngine;

        private readonly IPathBuilder<T> _builder;

        public FilePathOrchestrator(IPathDecisionEngine<T> decisionEngine, IPathBuilder<T> builder)
        {
            _decisionEngine=decisionEngine;
            _builder=builder;
        }

        public string BuildFilePath(T candidate)
        {

            var providers = _decisionEngine.DecideProviders(candidate);

            return _builder.Build(candidate, providers);
        }

    }
}
