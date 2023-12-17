using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record TimeInterval
{
    public XmlTimeIntervalField? QuantityTimeInterval { get; init; }

    [XmlElement("Reason")]
    public Reason[]? Reason { get; init; }
}
