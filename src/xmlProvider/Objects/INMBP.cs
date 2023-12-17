using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record INMBP : TrescBase
{
    public string? KDUB { get; init; }

    [XmlElement("TS")]
    public GrafikINMBP[]? TS { get; init; }
}
