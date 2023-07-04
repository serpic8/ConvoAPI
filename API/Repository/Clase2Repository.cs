using API.Data;
using API.Models;
using API.Repository.IRepository;

namespace API.Repository
{
    public class Clase2Repository : Repository<Clase2>, IClase2Repository
    {
        private readonly DataContext _db;

        public Clase2Repository(DataContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Clase2> AddLibros(Clase2 entity)
        {
            await _db.clase2.AddAsync(entity);
            return entity;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Clase2> Update(Clase2 entity)
        {
            _db.clase2.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Clase2> GetById(int id)
        {
            return await _db.clase2.FindAsync(id);
        }

        public async Task Delete(Clase2 entity)
        {
            _db.clase2.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
