using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CalculatorDatabase
{
    public class ContextFactory : IDesignTimeDbContextFactory<CalculatorContext>
    {
        readonly string connectionString = "Server=(localdb)\\mssqllocaldb;Database=SimpleCalculator;Integrated Security=True";

        public CalculatorContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder();
            dbContextBuilder.UseSqlServer(connectionString);

            return new CalculatorContext(dbContextBuilder.Options);
        }
    }
}
