using API.Data;
using API.Models;
using API.Repository.IRepository;

namespace API.Repository
{
    public class Clase3Repository : Repository<Clase3>, IClase3Repository
    {
        private readonly DataContext _db;

        public Clase3Repository(DataContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Clase3> AddLibros(Clase3 entity)
        {
            await _db.clase3.AddAsync(entity);
            return entity;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Clase3> Update(Clase3 entity)
        {
            _db.clase3.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Clase3> GetById(int id)
        {
            return await _db.clase3.FindAsync(id);
        }

        public async Task Delete(Clase3 entity)
        {
            _db.clase3.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
