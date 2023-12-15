using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record ZUSE_ZUSEB : TrescBase
{
    public required string KJB { get; init; }

    public required string KPOB { get; init; }

    [XmlElement("TS")]
    public required GrafikZUSE_ZUSEB[]? TS { get; init; }
}
