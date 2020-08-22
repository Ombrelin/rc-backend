using RencontreContemporainesAPI.Models;

namespace RencontreContemporainesAPI.Services.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
    
}