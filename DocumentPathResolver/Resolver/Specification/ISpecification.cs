namespace DocumentPathResolver.Resolver.Specification;

public interface ISpecification<T> where T : class
{
    bool IsSatisfiedBy(T candidate);
}
