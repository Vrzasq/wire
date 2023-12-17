using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIdentyfikacyjneJG
{
    public string? KJG { get; init; }

    [XmlElement("TS")]
    public GrafikINMBU[]? TS { get; init; }
}
