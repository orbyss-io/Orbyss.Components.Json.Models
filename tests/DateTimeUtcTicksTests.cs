namespace Orbyss.Components.Json.Models.Tests;

public sealed class DateTimeUtcTicksTests
{
    [Test]
    public void When_Instantiate_Then_Sets_Properties()
    {
        // Arrange
        var dateTime = DateTimeOffset.UtcNow.AddMinutes(-34);
        var ticks = dateTime.Ticks;

        // Act
        var result = new DateTimeUtcTicks(ticks);

        // Assert
        Assert.That(result.UtcTicks, Is.EqualTo(ticks));
        Assert.That(result.DateTime, Is.EqualTo(dateTime));
    }
}