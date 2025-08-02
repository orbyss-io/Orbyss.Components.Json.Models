# Orbyss.Components.Json.Models

Shared models used by the Orbyss ecosystem for schema-driven UI rendering, such as JSON-based forms and data grids.  
This package is part of the [Orbyss.io](https://orbyss.io) open-source initiative to simplify UI generation for .NET applications. 
These shared models are used for translations and for handling dates and times using ticks rather than text.

💡 These models are consumed by other Orbyss components: 
  - [Orbyss.Components.JsonForms](https://github.com/orbyss-io/Orbyss.Components.JsonForms) 
  - [Orbyss.Components.Syncfusion.JsonDataGrid](https://github.com/orbyss-io/Orbyss.Components.Syncfusion.JsonDataGrid)

---

## 🧩 Models Included

### `DateTimeUtcTicks`

A readonly struct for UTC-based date-time representations.

```csharp
public readonly struct DateTimeUtcTicks
{
    public DateTimeOffset DateTime { get; }
    public long UtcTicks { get; }
}
```

### `DateUtcTicks`

A readonly struct for UTC-based date representations, including way to get the day range (00:00 - 23.59).

```csharp
public readonly struct DateUtcTicks
{
    public long UtcTicks { get; }
    public DateOnly DateOnly { get; }

    public (DateTime start, DateTime end) GetDayRange();
}
```


### `TranslationSchema`

This package also defines the shape of our i18n translation schema, compatible with tools like i18next or your own .NET localization pipeline.
This structure allows you to localize field labels, enums, tooltips, and validation messages in dynamic forms or tables.

```json
{
  "resources": {
    "en": {
      "translation": {
        "firstName": {
            "label": "First name",
            "error":{
                "minLength": "Must have more than ...",
                "maxLength": "Too many characters..."
            }
        },
        "personTypeEnum":{
            "label": "Person type",
            "FamilyType": "Family",
            "PartnerType": "Partner",
            "BusinessType": "Business"
        }
      }
    }
  }
}
```

---

## 🤝 Contributing

This project is open source and contributions are welcome!

Whether it's bug fixes, improvements, documentation, or ideas — we encourage developers to get involved.  
Just fork the repo, create a branch, and open a pull request.

We follow standard .NET open-source conventions:
- Write clean, readable code
- Keep PRs focused and descriptive
- Open issues for larger features or discussions

No formal contribution guidelines — just be constructive and respectful.

---

## 🔗 Links

- 🌍 **Website**: [https://orbyss.io](https://orbyss.io)
- 📦 **NuGet**: *Coming soon*
- 🧑‍💻 **GitHub**: [https://github.com/Orbyss-io](https://github.com/orbyss-io)
- 📝 **License**: [MIT](./LICENSE)


---

⭐️ If you find this useful, [give us a star](https://github.com/orbyss-io/Orbyss.Components.Json.Models/stargazers) and help spread the word!