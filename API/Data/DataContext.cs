using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Clase1> clase1 => Set<Clase1>();
        public DbSet<Clase2> clase2 => Set<Clase2>();
        public DbSet<Clase3> clase3 => Set<Clase3>();
        public DbSet<Clase4> clase4 => Set<Clase4>();
        public DbSet<User> user => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "admin",
                    Password = "123.",
                    Role = "Admin"
                },
                new User()
                {
                    Id = 2,
                    Name = "usuario",
                    Password = "123.",
                    Role = "Public"
                }
            );
           
        }


    }
}
