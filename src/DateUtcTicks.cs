namespace Orbyss.Components.Json.Models;

public readonly struct DateUtcTicks
{
    public readonly long UtcTicks;
    public readonly DateOnly DateOnly;

    private readonly DateTime start;
    private readonly DateTime end;

    public (DateTime start, DateTime end) GetDayRange()
    {
        return (
            start,
            end
        );
    }

    public DateUtcTicks(long utcTicks)
    {
        UtcTicks = utcTicks;
        var dateTime = new DateTimeOffset(utcTicks, TimeSpan.Zero);
        DateOnly = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        start = DateOnly.ToDateTime(TimeOnly.MinValue);
        end = DateOnly.ToDateTime(TimeOnly.MaxValue);
    }
}
