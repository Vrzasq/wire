using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record ZPP : TrescBase
{
    public required string KDUB { get; init; }

    public required string KJG { get; init; }

    [XmlElement("TS")]
    public required GrafikZPP[]? TS { get; init; }
}
