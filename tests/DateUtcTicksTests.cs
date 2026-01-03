namespace Orbyss.Components.Json.Models.Tests;

public sealed class DateUtcTicksTests
{
    [Test]
    public void When_Instantiate_Then_Sets_Properties()
    {
        // Arrange
        var dateTime = DateTime.UtcNow
            .AddYears(-1)
            .AddDays(2);
        var date = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        var ticks = dateTime.Ticks;

        // Act
        var result = new DateUtcTicks(ticks);

        // Assert
        Assert.That(result.UtcTicks, Is.EqualTo(ticks));
        Assert.That(result.DateOnly, Is.EqualTo(date));
    }

    [Test]
    public void When_GetDayRange_Then_Returns_Start_And_End_DateTime()
    {
        // Arrange
        var dateTime = DateTime.UtcNow
            .AddYears(-1)
            .AddDays(2);
        var sut = new DateUtcTicks(dateTime.Ticks);

        // Act
        var (start, end) = sut.GetDayRange();

        // Assert
        Assert.That(start.TimeOfDay, Is.EqualTo(TimeOnly.MinValue.ToTimeSpan()));
        Assert.That(start.Year, Is.EqualTo(dateTime.Year));
        Assert.That(start.Month, Is.EqualTo(dateTime.Month));
        Assert.That(start.Day, Is.EqualTo(dateTime.Day));

        Assert.That(end.TimeOfDay, Is.EqualTo(TimeOnly.MaxValue.ToTimeSpan()));
        Assert.That(end.Year, Is.EqualTo(dateTime.Year));
        Assert.That(end.Month, Is.EqualTo(dateTime.Month));
        Assert.That(end.Day, Is.EqualTo(dateTime.Day));
    }
}