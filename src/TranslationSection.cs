namespace Orbyss.Components.Json.Models
{
    public sealed record TranslationSection(
        string? Label,
        TranslationErrorSection? Error,
        IEnumerable<TranslatedEnumItem>? Enums,
        IDictionary<string, TranslationSection>? NestedSections
    );
}