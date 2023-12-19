using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record FDMB : TrescBase
{
    public string? KFDMB { get; init; }

    public GrafikFDMB? TS { get; init; }

    [XmlElement("LFDMB")]
    public LFDMB[]? LFDMB { get; init; }

}