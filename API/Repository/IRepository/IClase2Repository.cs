using API.Models;

namespace API.Repository.IRepository
{
    public interface IClase2Repository : IRepository<Clase2>
    {
        Task SaveAsync();

        Task<Clase2> Update(Clase2 entity);

        Task<Clase2> AddLibros(Clase2 entity);

        Task<Clase2> GetById(int id);

        Task Delete(Clase2 entity);
    }
}
