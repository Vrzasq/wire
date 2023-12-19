using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record PKOR : MessageIdBase
{
    [XmlAttribute]
    public override string DtdVersion { get; init; } = "1";

    [XmlAttribute]
    public override string DtdRelease { get; init; }  = "0";

    public XmlDateTimeField? DocumentDateTime { get; init; }

    public XmlStringCodingField? SenderIdentification { get; init; }

    public XmlStringField? SenderRole { get; init; }

    public XmlStringCodingField? ReceiverIdentification { get; init; }

    public XmlStringField? ReceiverRole { get; init; }

    public XmlStringField? ReceivingDocumentIdentification { get; init; }

    public XmlIntField? ReceivingDocumentVersion { get; init; }

    public XmlStringField? ReceivingDocumentType { get; init; }

    public XmlDateTimeField? DateTimeReceivingDocument { get; init; }
}
