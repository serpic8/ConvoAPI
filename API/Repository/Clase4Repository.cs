using API.Data;
using API.Models;
using API.Repository.IRepository;

namespace API.Repository
{
    public class Clase4Repository : Repository<Clase4>, IClase4Repository
    {
        private readonly DataContext _db;

        public Clase4Repository(DataContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Clase4> AddLibros(Clase4 entity)
        {
            await _db.clase4.AddAsync(entity);
            return entity;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Clase4> Update(Clase4 entity)
        {
            _db.clase4.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Clase4> GetById(int id)
        {
            return await _db.clase4.FindAsync(id);
        }

        public async Task Delete(Clase4 entity)
        {
            _db.clase4.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
