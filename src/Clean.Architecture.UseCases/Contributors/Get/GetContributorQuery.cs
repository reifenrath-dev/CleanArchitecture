using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Architecture.UseCases.Contributors.Get;

internal record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
