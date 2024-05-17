namespace Clean.Architecture.Web.Contributors;

internal class CreateContributorResponse(int id, string name)
{
  public int Id { get; set; } = id;
  public string Name { get; set; } = name;
}
