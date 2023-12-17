using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record ZGWM : MessageIdBase
{
    [XmlAttribute]
    public override string DtdVersion { get; init; } = "3";

    [XmlAttribute]
    public override string DtdRelease { get; init; }  = "3";

    public required XmlIntField MessageVersion { get; init; }

    public required XmlStringCodingField MessageType { get; init; }

    public required XmlStringField ProcessType { get; init; }

    public required XmlStringField ScheduleClassificationType { get; init; }

    public required XmlStringCodingField SenderIdentification { get; init; }

    public required XmlStringField SenderRole { get; init; }

    public required XmlStringCodingField ReceiverIdentification { get; init; }

    public required XmlStringField ReceiverRole { get; init; }

    public required XmlDateTimeField MessageDateTime { get; init; }

    public required XmlTimeIntervalField ScheduleTimeInterval { get; init; }

    [XmlElement("ScheduleTimeSeries")]
    public required ScheduleTime[] ScheduleTimeSeries { get; init; }
}
