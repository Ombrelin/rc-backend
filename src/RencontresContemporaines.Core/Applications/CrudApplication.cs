using RencontresContemporaines.Core.Domain;
using RencontresContemporaines.Core.Repositories;

namespace RencontresContemporaines.Core.Applications;

public class CrudApplication<TEntity> where TEntity : Entity
{
    private readonly IRepository<TEntity> repository;

    public CrudApplication(IRepository<TEntity> repository)
    {
        this.repository = repository;
    }


    public Task<IEnumerable<TEntity>> GetAll() => repository.GetAll();

    public Task<TEntity> GetById(Guid id) => repository.GetById(id);

    public Task Create(TEntity entity) => repository.Insert(entity);

    public Task Update(TEntity entity) => repository.Update(entity);

    public Task Delete(Guid id) => repository.Delete(id);
}