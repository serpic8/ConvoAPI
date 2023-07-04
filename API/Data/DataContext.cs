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
        

    }
}
