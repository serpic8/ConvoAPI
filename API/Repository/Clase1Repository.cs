using API.Data;
using API.Models;
using API.Repository.IRepository;

namespace API.Repository
{
    public class Clase1Repository : Repository<Clase1>, IClase1Repository
    {
        private readonly DataContext _db;

        public Clase1Repository(DataContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Clase1> AddLibros(Clase1 entity)
        {
            await _db.clase1.AddAsync(entity);
            return entity;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Clase1> Update(Clase1 entity)
        {
            _db.clase1.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Clase1> GetById(int id)
        {
            return await _db.clase1.FindAsync(id);
        }

        public async Task Delete(Clase1 entity)
        {
            _db.clase1.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
