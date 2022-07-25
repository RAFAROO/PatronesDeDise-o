using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatronesDeDiseñoConsole.PatronRepositorio.Contracts
{
    public interface IEemploRepositorio<T>
    {
        Task<IReadOnlyList<T>> GetAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        void Save();
    }
}
