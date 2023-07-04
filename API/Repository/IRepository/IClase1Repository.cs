using API.Models;

namespace API.Repository.IRepository
{
    public interface IClase1Repository : IRepository<Clase1>
    {
        Task SaveAsync();

        Task<Clase1> Update(Clase1 entity);

        Task<Clase1> AddLibros(Clase1 entity);

        Task<Clase1> GetById(int id);

        Task Delete(Clase1 entity);
    }
}
