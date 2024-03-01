﻿using Ardalis.Result;

namespace Clean.Architecture.UseCases.Contributors.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
internal record CreateContributorCommand(string Name, string? PhoneNumber) : Ardalis.SharedKernel.ICommand<Result<int>>;
