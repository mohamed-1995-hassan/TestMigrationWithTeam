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
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Type> Types { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class CountryCode
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Address
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
    public class Type
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
