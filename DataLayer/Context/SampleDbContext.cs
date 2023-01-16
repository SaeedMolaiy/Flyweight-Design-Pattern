using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new HashSet<Person>
            {
                new()
                {
                    PersonId = 1,
                    FirstName = "Saeed",
                    LastName = "Molaiy",
                    Age = 20,
                }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
