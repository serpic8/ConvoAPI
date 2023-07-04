using API.Models;

namespace API.Repository.IRepository
{
    public interface IClase3Repository : IRepository<Clase3>
    {
        Task SaveAsync();

        Task<Clase3> Update(Clase3 entity);

        Task<Clase3> AddLibros(Clase3 entity);

        Task<Clase3> GetById(int id);

        Task Delete(Clase3 entity);
    }
}
