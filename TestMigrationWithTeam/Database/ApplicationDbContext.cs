using Microsoft.EntityFrameworkCore;

namespace TestMigrationWithTeam.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
             
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CountryCode> CountryCodes { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CountryCode
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
