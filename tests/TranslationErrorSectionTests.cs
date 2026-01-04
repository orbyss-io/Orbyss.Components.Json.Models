using System;
using System.Collections.Generic;
using System.Text;

namespace Orbyss.Components.Json.Models.Tests;

[TestFixture]
public sealed class TranslationErrorSectionTests
{
    [Test]
    public void When_GetAll_Then_Returns_AllSpecifiedProperties()
    {
        // Arrange
        var section = new TranslationErrorSection(
            Const: "Const Message",
            Minimum: "Minimum Message",
            Maximum: "Maximum Message",
            MinimumLength: "Min Length Message",
            MaximumLength: "Max Length Message",
            MinimumItems: "Min Items Message",
            MaximumItems: "Max Items Message",
            Required: "Required Message",
            Custom: "Custom Message",
            Contains: "Contains Message",
            Pattern: "Pattern Message"
        );

        // Act
        var result = section.GetAll();

        // Assert
        Assert.That(result.Count(), Is.EqualTo(11));
        Assert.That(result, Does.Contain("Const Message"));
        Assert.That(result, Does.Contain("Minimum Message"));
        Assert.That(result, Does.Contain("Maximum Message"));
        Assert.That(result, Does.Contain("Min Length Message"));
        Assert.That(result, Does.Contain("Max Length Message"));
        Assert.That(result, Does.Contain("Min Items Message"));
        Assert.That(result, Does.Contain("Max Items Message"));
        Assert.That(result, Does.Contain("Required Message"));
        Assert.That(result, Does.Contain("Custom Message"));
        Assert.That(result, Does.Contain("Contains Message"));
        Assert.That(result, Does.Contain("Pattern Message"));
    }
}
