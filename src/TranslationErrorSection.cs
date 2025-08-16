namespace Orbyss.Components.Json.Models
{
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
        public string GetConst() => GetValueOrDefault(Const, DefaultJsonFormValidationMessages.Const);
        public string GetMinimum() => GetValueOrDefault(Minimum, DefaultJsonFormValidationMessages.Minimum);
        public string GetMaximum() => GetValueOrDefault(Maximum, DefaultJsonFormValidationMessages.Maximum);
        public string GetMinimumLength() => GetValueOrDefault(MinimumLength, DefaultJsonFormValidationMessages.MinLength);
        public string GetMaximumLength() => GetValueOrDefault(MaximumItems, DefaultJsonFormValidationMessages.MaxLength);
        public string GetMinimumItems() => GetValueOrDefault(MinimumItems, DefaultJsonFormValidationMessages.MinItems);
        public string GetMaximumItems() => GetValueOrDefault(MaximumItems, DefaultJsonFormValidationMessages.MaxItems);

        public string GetContains() => GetValueOrDefault(Contains, DefaultJsonFormValidationMessages.Contains);
        public string GetRequired() => GetValueOrDefault(Required, DefaultJsonFormValidationMessages.Required);
        public string GetPattern() => GetValueOrDefault(Pattern, DefaultJsonFormValidationMessages.Pattern);
        public string GetDefault() => GetValueOrDefault(Custom, DefaultJsonFormValidationMessages.Default);

        string GetValueOrDefault(string? value, string defaultValue)
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
}