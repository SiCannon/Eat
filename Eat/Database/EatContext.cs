using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Eat.Entity;

namespace Eat.Database
{
    public class EatContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        static EatContext()
        {
            System.Data.Entity.Database.SetInitializer<EatContext>(new EatDatabaseInitializer());
        }
    }
}