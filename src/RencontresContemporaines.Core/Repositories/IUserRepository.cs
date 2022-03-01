using RencontresContemporaines.Core.Domain;

namespace RencontresContemporaines.Core.Repositories;

public interface UserRepository : IRepository<User>
{
    Task<User> GetByUsername(string username);
}