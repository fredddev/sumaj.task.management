using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sumaj.Task.Management.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T>  where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size);
    }
}
