using Ardalis.Specification;

namespace Clean.Architecture.Core.ContributorAggregate.Specifications;

internal class ContributorByIdSpec : Specification<Contributor>
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
