using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record TSPR
{
    public Okres? DT { get; init; }

    public string? R { get; init; }

    [XmlElement("TR")]
    public TR[]? TR { get; init; }
}
