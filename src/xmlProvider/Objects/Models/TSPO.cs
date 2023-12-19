using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record TSPO
{
    public Okres? DT { get; init; }

    public string? R { get; init; }

    [XmlElement("TO")]
    public TO[]? TO { get; init; }
}
