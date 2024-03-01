using Clean.Architecture.Web.ContributorEndpoints;

namespace Clean.Architecture.Web.Endpoints.ContributorEndpoints;

internal class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = [];
}
