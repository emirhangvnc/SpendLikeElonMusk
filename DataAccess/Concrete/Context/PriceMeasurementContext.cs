using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Context
{
    public class PriceMeasurementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PriceMeasurement;Trusted_Connecion=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CompanyWealth> companyWealths { get; set; }
        public DbSet<Favorite> favorites { get; set; }
        public DbSet<Fortune> fortunes { get; set; }
        public DbSet<PersonalWealth> personalWealths { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}