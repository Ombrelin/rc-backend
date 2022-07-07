using RencontresContemporaines.Core.Domain;

namespace RencontresContemporaines.Core.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<User> GetByUsername(string username);
}