using System.ComponentModel.DataAnnotations;

namespace Clean.Architecture.Web.Endpoints.ContributorEndpoints;

internal class CreateContributorRequest
{
  public const string Route = "/Contributors";

  [Required]
  public string? Name { get; set; }
  public string? PhoneNumber { get; set; }
}
