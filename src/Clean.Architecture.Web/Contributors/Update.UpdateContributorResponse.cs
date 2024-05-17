namespace Clean.Architecture.Web.Contributors;

internal class UpdateContributorResponse(ContributorRecord contributor)
{
  public ContributorRecord Contributor { get; set; } = contributor;
}
