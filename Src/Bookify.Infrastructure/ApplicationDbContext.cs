using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bookify.Infrastructure;

public sealed class ApplicationDbContext(DbContextOptions options)
    : DbContext(options), IUnitOfWork
{
    #region Overrides of DbContext

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Application.DependencyInjection).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    #endregion
}