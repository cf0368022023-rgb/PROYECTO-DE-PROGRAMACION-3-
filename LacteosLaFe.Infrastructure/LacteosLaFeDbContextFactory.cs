using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LacteosLaFe.Infrastructure
{
    public class LacteosLaFeDbContextFactory
        : IDesignTimeDbContextFactory<LacteosLaFeDbContext>
    {
        public LacteosLaFeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<LacteosLaFeDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=MANUEL;Database=LacteosLaFeDB;Trusted_Connection=True;TrustServerCertificate=True"
            );

            return new LacteosLaFeDbContext(optionsBuilder.Options);
        }
    }
}