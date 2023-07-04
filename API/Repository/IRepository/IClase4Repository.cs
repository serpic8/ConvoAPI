using API.Models;

namespace API.Repository.IRepository
{
    public interface IClase4Repository : IRepository<Clase4>
    {
        Task SaveAsync();

        Task<Clase4> Update(Clase4 entity);

        Task<Clase4> AddLibros(Clase4 entity);

        Task<Clase4> GetById(int id);

        Task Delete(Clase4 entity);
    }
}
