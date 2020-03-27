using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TreatTracker.Models
{
  public class TreatTrackerContextFactory : IDesignTimeDbContextFactory<TreatTrackerContext>
  {

    TreatTrackerContext IDesignTimeDbContextFactory<TreatTrackerContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<TreatTrackerContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new TreatTrackerContext(builder.Options);
    }
  }
}