using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweZOEB : DaneIloscioweBase
{
    /// <summary>
    /// decimal
    /// </summary>
    public string? PMAX { get; init; }

    /// <summary>
    /// decimal
    /// </summary>
    public string? PMIN { get; init; }

    /// <summary>
    /// int
    /// </summary>
    public string? WRE { get; init; }

    [XmlElement("B")]
    public PasmoPozycjiGrafiku[]? B { get; init; }
}
