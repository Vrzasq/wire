using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweRO : DaneIloscioweBase
{
    public decimal RO { get; init; }

    [XmlElement("ROM")]
    public ROM[]? ROM { get; init; }
}

public record ROM
{
    public string? MT { get; init; }

    public string? OREB { get; init; }

    public decimal ROR { get; init; }

    public decimal NRO { get; init; }
}
