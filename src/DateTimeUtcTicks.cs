namespace Orbyss.Components.Json.Models
{
    public readonly struct DateTimeUtcTicks(long utcTicks)
    {
        public readonly DateTimeOffset DateTime = new(utcTicks, TimeSpan.Zero);
        public readonly long UtcTicks = utcTicks;
    }
}
