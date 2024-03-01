using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Architecture.UseCases.Contributors.Update;

internal record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
