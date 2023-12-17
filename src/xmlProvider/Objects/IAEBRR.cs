using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record IAEBRR : TrescBase
{
    public string? KDUB { get; init; }

    [XmlElement("TS")]
    public GrafikIAEBRR[]? TS { get; init; }
}
