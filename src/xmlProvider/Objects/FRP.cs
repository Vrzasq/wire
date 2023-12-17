using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record FRP : TrescBase
{
    [XmlElement("XmlElement")]
    public LFRP[]? LFRP { get; set; }

    public string? KFRP { get; init; }

    public GrafikFRP? TS { get; init; }
}