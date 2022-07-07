namespace RencontresContemporaines.Core.Domain;

public struct ConcertDate
{
    private static readonly string DEFAULT_DATE_FORMAT = "";
    
    public List<TimeSpan> Hours { get; set; }
    public DateOnly? Date { get; set; }
    private bool isDateSure;

    public Boolean IsDateSure
    {
        get => isDateSure;
        set => isDateSure = Date is null ? value : throw new ArgumentException();
    }

    public string DateFormat { get; set; }

    public ConcertDate()
    {
        isDateSure = false;
        Hours = new List<TimeSpan>();
        DateFormat = DEFAULT_DATE_FORMAT;
        Date = null;
    }
}