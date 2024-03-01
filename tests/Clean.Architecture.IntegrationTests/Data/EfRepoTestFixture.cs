using Clean.Architecture.Infrastructure.Data;
using Ardalis.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Clean.Architecture.Core.ContributorAggregate;
using NSubstitute;

namespace Clean.Architecture.IntegrationTests.Data;

internal class EfRepoTestFixture
{
  internal readonly AppDbContext DbContext;

  public EfRepoTestFixture()
  {
    var options = CreateNewContextOptions();
    var _fakeEventDispatcher = Substitute.For<IDomainEventDispatcher>();

    DbContext = new AppDbContext(options, _fakeEventDispatcher);
  }

  private static DbContextOptions<AppDbContext> CreateNewContextOptions()
  {
    // Create a fresh service provider, and therefore a fresh
    // InMemory database instance.
    var serviceProvider = new ServiceCollection()
        .AddEntityFrameworkInMemoryDatabase()
        .BuildServiceProvider();

    // Create a new options instance telling the context to use an
    // InMemory database and the new service provider.
    var builder = new DbContextOptionsBuilder<AppDbContext>();
    builder.UseInMemoryDatabase("cleanarchitecture")
           .UseInternalServiceProvider(serviceProvider);

    return builder.Options;
  }

  public EfRepository<Contributor> GetRepository()
  {
    return new EfRepository<Contributor>(DbContext);
  }
}
