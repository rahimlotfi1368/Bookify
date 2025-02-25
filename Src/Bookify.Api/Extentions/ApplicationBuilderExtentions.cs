using Bookify.Infrastructure;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Api.Extentions;

public static class ApplicationBuilderExtentions
{
     public static void ApplyMigrations(this IApplicationBuilder app)
     {
          using var scope = app.ApplicationServices.CreateScope();
          using var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
          dbContext.Database.Migrate();
     }
}