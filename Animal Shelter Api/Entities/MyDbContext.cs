using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace Animal_Shelter_Api.Entities
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<Owner> Owner { get; set; }

    }
}
