using bernwebapp.Models;
using Microsoft.EntityFrameworkCore;

namespace bernwebapp.Data
{
    public class ApplicationDBContext : DbContext
    {
        //pass the connection string to the base class
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Web Development", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Programming", DisplayOrder = 2 },
               new Category { Id = 3, Name = "Data Science", DisplayOrder = 3 }
            );
        }
    }
}
