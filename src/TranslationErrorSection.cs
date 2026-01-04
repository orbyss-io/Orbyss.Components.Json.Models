using System.Data;
using System.Reflection;

namespace Orbyss.Components.Json.Models;

public sealed record TranslationErrorSection(
    string? Custom,
    string? Const,
    string? Required,
    string? Minimum,
    string? Maximum,
    string? MinimumLength,
    string? MaximumLength,
    string? MinimumItems,
    string? MaximumItems,
    string? Contains,
    string? Pattern)
{
    public string GetConst()
    {
        return GetValueOrDefault(Const, DefaultJsonFormValidationMessages.Const);
    }

    public string GetMinimum()
    {
        return GetValueOrDefault(Minimum, DefaultJsonFormValidationMessages.Minimum);
    }

    public string GetMaximum()
    {
        return GetValueOrDefault(Maximum, DefaultJsonFormValidationMessages.Maximum);
    }

    public string GetMinimumLength()
    {
        return GetValueOrDefault(MinimumLength, DefaultJsonFormValidationMessages.MinLength);
    }

    public string GetMaximumLength()
    {
        return GetValueOrDefault(MaximumItems, DefaultJsonFormValidationMessages.MaxLength);
    }

    public string GetMinimumItems()
    {
        return GetValueOrDefault(MinimumItems, DefaultJsonFormValidationMessages.MinItems);
    }

    public string GetMaximumItems()
    {
        return GetValueOrDefault(MaximumItems, DefaultJsonFormValidationMessages.MaxItems);
    }

    public string GetContains()
    {
        return GetValueOrDefault(Contains, DefaultJsonFormValidationMessages.Contains);
    }

    public string GetRequired()
    {
        return GetValueOrDefault(Required, DefaultJsonFormValidationMessages.Required);
    }

    public string GetPattern()
    {
        return GetValueOrDefault(Pattern, DefaultJsonFormValidationMessages.Pattern);
    }

    public string GetDefault()
    {
        return GetValueOrDefault(Custom, DefaultJsonFormValidationMessages.Default);
    }

    public IEnumerable<string> GetAll()
    {
        var properties = GetType()
            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Select(x => $"{x.GetValue(this)}")
            .Where(x => !string.IsNullOrWhiteSpace(x));

        if(!properties.Any())
        {
            return [GetDefault()];
        }

        return properties;
    }

    private string GetValueOrDefault(string? value, string defaultValue)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        if (!string.IsNullOrWhiteSpace(Custom))
        {
            return Custom;
        }

        return defaultValue;
    }

    public static TranslationErrorSection DefaultSection()
    {
        return new(
           null, null, null, null, null, null, null, null, null, null, null
       );
    }
}