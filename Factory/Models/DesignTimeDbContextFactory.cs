using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Factory.Models
{
  public class FactoryContextFactory : IdesignTimeDbContextFactory<FactoryContext>
  {
    FactoryContext IdesignTimeDbContextFactory<FactoryContext>.CreateDbContext(sting[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
      
      var builder = new DbContextOptionsBuilder<FactoryContext>();
      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new FactoryContext(builder.Options);
    }
  }
}