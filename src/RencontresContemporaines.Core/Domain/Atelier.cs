
namespace RencontresContemporaines.Core.Domain;

public class Atelier : Entity
{
    public DateTime Date { get; set; }
    public string? Comment { get; set; }

    public Atelier(Guid id, DateTime dateTime) : base(id)
    {
    }
}