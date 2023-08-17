using Microsoft.EntityFrameworkCore;
using Web_Api_Project.Models;
using Web_Api_Project.Seeding;

namespace Web_Api_Project
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mark the Employee Class Field as Required . AlterNate to [Required] Annotation.
            modelBuilder.Entity<Author>().Property(e => e.Email).IsRequired();
            Module3Seeding.seed(modelBuilder);   
        }

        
        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        {
            // Here, we are configuring that the class properties having DateTime Datatype will be converted into Data type in Database
            modelConfigurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
