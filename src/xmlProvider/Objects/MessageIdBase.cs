using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public abstract record MessageIdBase
{
    [XmlAttribute]
    public abstract string DtdVersion { get; init; }

    [XmlAttribute]
    public abstract string DtdRelease { get; init; }

    public required XmlStringField MessageIdentification { get; init; }

    [XmlElement("Reason")]
    public Reason[]? Reason { get; init; }

}
