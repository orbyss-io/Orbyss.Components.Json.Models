using System.Text.Json.Serialization;

namespace Orbyss.Components.Json.Models;

[JsonConverter(typeof(TranslationSectionJsonConverter))]
public sealed record TranslationSection(
    string? Label,
    TranslationErrorSection? Error,
    IEnumerable<TranslatedEnumItem>? Enums,
    IDictionary<string, TranslationSection>? NestedSections
);