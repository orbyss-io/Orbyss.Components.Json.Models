namespace Orbyss.Components.Json.Models;

public sealed class TranslationResourcesDictionary : Dictionary<string, TranslationSchemaResource>
{
    public TranslationResourcesDictionary() : base(StringComparer.OrdinalIgnoreCase)
    {
    }

    public TranslationResourcesDictionary(IDictionary<string, TranslationSchemaResource> dictionary)
        : base(dictionary, StringComparer.OrdinalIgnoreCase)
    {
    }

    public TranslationResourcesDictionary(IEnumerable<KeyValuePair<string, TranslationSchemaResource>> collection)
        : base(collection, StringComparer.OrdinalIgnoreCase)
    {
    }
}
