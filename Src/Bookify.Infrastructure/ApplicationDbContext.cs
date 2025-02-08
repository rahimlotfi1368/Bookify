using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bookify.Infrastructure;

public sealed class ApplicationDbContext(DbContextOptions options) 
    : DbContext(options), IUnitOfWork;