using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace xmlObjectProvider.Objects;

[SuppressMessage("Style", "IDE1006:Naming Styles")]
[DebuggerStepThrough]
[Serializable]
[XmlType(Namespace = "http://www.pse.pl/osp")]
public record Naglowek
{
    public string id { get; init; } = Guid.NewGuid().ToString();
    public string wersja { get; init; } = "WIRE 14.0";
    public DateTime data_utworzenia { get; init; } = DateTime.Now;

    public required string kod_kom { get; init; }

    [XmlElement(DataType = "date")]
    public required DateTime data { get; init; }

    public required string kod_obiektu { get; init; }

    public string? ref_id { get; init; }
}