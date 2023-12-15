using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record ZOEB : TrescBase
{
    public required string KJG { get; init; }

    public required string KDUB { get; init; }

    [XmlElement("TS")]
    public required GrafikZOEB[]? TS { get; init; }
}
