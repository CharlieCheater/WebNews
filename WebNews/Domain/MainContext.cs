using Microsoft.EntityFrameworkCore;

namespace WebNews.Domain
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Publication> Publications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Publication>().HasData(new List<Publication>()
            {
                new Publication { Id = 1, Author = "Charlie", Description = "Это описание", Title = "Это заголовок" }
            });
        }
    }
}
