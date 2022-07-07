using RencontresContemporaines.Core.Domain;

namespace RencontresContemporaines.Core.Repositories;

public interface IRepository<T> where T : Entity
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(Guid id);
    Task Insert(T entity);
    Task Update(T entity);
    Task Delete(Guid id);
}