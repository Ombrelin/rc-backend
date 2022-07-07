namespace RencontresContemporaines.Core.Domain;

public struct ConcertLocation
{
    public string Location { get; set; }
    private bool isLocationSure;

    public Boolean LocationSure
    {
        get => isLocationSure;
        set => isLocationSure = string.IsNullOrEmpty(Location) ? throw new ArgumentException() : value;
    }

    public ConcertLocation(string location)
    {
        Location = location;
        isLocationSure = false;
    }
}