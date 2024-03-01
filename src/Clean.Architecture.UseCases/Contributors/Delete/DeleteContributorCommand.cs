using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Clean.Architecture.UseCases.Contributors.Delete;

internal record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
