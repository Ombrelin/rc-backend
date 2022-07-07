namespace RencontresContemporaines.Core.Domain;

public class Concert : Entity
{
    private string title;

    public string Title
    {
        get => title;
        set => title = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
    }

    private string artist;

    public string Artist
    {
        get => artist;
        set => artist = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
    }

    private string description;

    public string Description
    {
        get => description;
        set => description = string.IsNullOrEmpty(value) ? throw new ArgumentException() : value;
    }

    public ConcertDate Date {get;set;}
    public ConcertLocation Location {get;set;}

    public Guid ImageId { get; set; }
    public Guid FlyerId { get; set; }

    public Concert(
        Guid id,
        string title,
        string artist,
        string description) : base(id)
    {
        Title = title;
        Artist = artist;
        Description = description;
    }
}