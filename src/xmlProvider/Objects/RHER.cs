using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record RHER : TrescBase
{
    public string? KOB { get; init; }

    public GrafikRHER? TS { get; init; }

    [XmlElement("MB")]
    public MB[]? MB { get; init; }

    [XmlElement("FDMB")]
    public D_FDMB[]? FDMB { get; init; }

    [XmlElement("FDMBS")]
    public D_FDMBS? FDMBS { get; init; }
}