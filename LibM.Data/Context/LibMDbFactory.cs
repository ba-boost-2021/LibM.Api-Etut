using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LibM.Data.Context
{
    public class LibMDbFactory : IDesignTimeDbContextFactory<LibMDbContext>
    {
        public LibMDbContext CreateDbContext(string[] args)
        {
            //var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            //if (enviroment == null)
            //{
            //    enviroment = "Development";
            //}
            var connectionString = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile($"appsettings.json", false, true).Build()
                                    .GetSection("Local").Value;
            var optionBuilder = new DbContextOptionsBuilder<LibMDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new LibMDbContext(optionBuilder.Options);
        }
    }
}
