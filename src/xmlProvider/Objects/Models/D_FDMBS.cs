using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record D_FDMBS
{
    public string? KFDMBS { get; init; }

    public GrafikRHER? TS { get; init; }

    [XmlElement("ALG")]
    public ALG[]? ALG { get; set; }
}
