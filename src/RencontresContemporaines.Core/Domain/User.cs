using System.ComponentModel.DataAnnotations.Schema;

namespace RencontresContemporaines.Core.Domain;

public class User : Entity
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(Guid id) : base(id)
    {
        
    }
}