using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record OT : TrescBase
{
    public required string KJG { get; init; }

    public required string KDUB { get; init; }

    [XmlElement("TS")]
    public GrafikZOT[]? TS { get; init; }
}
