using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record UGWM : MessageIdBase
{
    [XmlAttribute]
    public override string DtdVersion { get; init; } = "3";

    [XmlAttribute]
    public override string DtdRelease { get; init; }  = "3";

    public XmlStringField? MessageType { get; init; }

    public XmlDateTimeField? MessageDateTime { get; init; }

    public XmlStringCodingField? SenderIdentification { get; init; }

    public XmlStringField? SenderRole { get; init; }

    public XmlStringCodingField? ReceiverIdentification { get; init; }

    public XmlStringField? ReceiverRole { get; init; }

    public XmlTimeIntervalField? ScheduleTimeInterval { get; init; }

    public XmlStringField? ConfirmedMessageIdentification { get; init; }

    public XmlIntField? ConfirmedMessageVersion { get; init; }

    public XmlStringCodingField? Domain { get; init; }

    public XmlStringCodingField? SubjectParty { get; init; }

    public XmlStringField? SubjectRole { get; init; }

    public XmlStringField? ProcessType { get; init; }

    [XmlElement("ImposedTimeSeries")]
    public ScheduleTime[]? ImposedTimeSeries { get; init; }

    [XmlElement("TimeSeriesConfirmation")]
    public ScheduleTime[]? TimeSeriesConfirmation { get; init; }
}
