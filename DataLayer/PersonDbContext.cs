using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataLayer
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships (optional)
            modelBuilder.Entity<Person>();
        }
    }
}
