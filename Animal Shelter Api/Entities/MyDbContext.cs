using Microsoft.EntityFrameworkCore;

namespace Animal_Shelter_Api.Entities
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<Owner> Owner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().HasData(new { Id = 1, Name = "Henrik" });
            modelBuilder.Entity<Owner>().HasData(new { Id = 2, Name = "Emil" });

            modelBuilder.Entity<Dog>().HasData(new { Id = 1, Name = "Herr Senap", OwnerId = 1});
            modelBuilder.Entity<Dog>().HasData(new { Id = 2, Name = "T-rex", OwnerId = 1});
            modelBuilder.Entity<Dog>().HasData(new { Id = 3, Name = "Jamie", OwnerId = 2 });

            modelBuilder.Entity<Dog>().HasOne<Owner>(d => d.Owner).WithMany(o => o.Dogs).HasForeignKey(o => o.OwnerId);

        }

    }
}
