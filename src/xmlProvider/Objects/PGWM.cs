using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record PGWM : MessageIdBase
{
    [XmlAttribute]
    public override string DtdVersion { get; init; } = "0";

    [XmlAttribute]
    public override string DtdRelease { get; init; }  = "5";

    public XmlDateTimeField? DocumentDateTime { get; init; }

    public XmlStringCodingField? SenderIdentification { get; init; }

    public XmlStringField? SenderRole { get; init; }

    public XmlStringCodingField? ReceiverIdentification { get; init; }

    public XmlStringField? ReceiverRole { get; init; }

    public XmlStringField? ReceivingDocumentIdentification { get; init; }

    public XmlIntField? ReceivingDocumentVersion { get; init; }

    public XmlStringCodingField? ReceivingDocumentType { get; init; }

    [XmlElement("TimeSeriesRejection")]
    public TimeSeries[]? TimeSeriesRejection { get; init; }

    [XmlElement("TimeIntervalError")]
    public TimeInterval[]? TimeIntervalError { get; init; }
}
