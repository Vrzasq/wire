using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record Period
{
    public required XmlTimeIntervalField TimeInterval { get; init; }

    public XmlStringField Resolution { get; init; } = "PT15M";

    [XmlElement("Interval")]
    public required Interval[] Interval { get; init; }
}
