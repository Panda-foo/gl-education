using CalculatorDatabase.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculatorDatabase
{
    public class CalculatorContext : DbContext
    {
        public DbSet<AdditionResult> AdditionResults { get; set; }
        public DbSet<SubtractionResult> SubtractionResults { get; set; }
        public DbSet<MultiplicationResult> MultiplicationResults { get; set; }
        public DbSet<DivisionResult> DivisionResults { get; set; }

        public DbSet<PrimeResult> PrimeResults { get; set; }

        public CalculatorContext(DbContextOptions options)
        : base(options)
        {
        }
    }
}
