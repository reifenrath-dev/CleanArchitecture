namespace Clean.Architecture.Web.Endpoints.ContributorEndpoints;

internal class CreateContributorResponse(int id, string name)
{
  public int Id { get; set; } = id;
  public string Name { get; set; } = name;
}
