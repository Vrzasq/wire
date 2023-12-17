using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record FRPO : TrescBase
{
    [XmlElement("LFRPO")]
    public LFRPO[]? LFRPO { get; set; }

    public string? KFRPO { get; init; }

    public GrafikFRPO? TS { get; init; }
}