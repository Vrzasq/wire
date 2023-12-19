using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record KOR : MessageIdBase
{
    [XmlAttribute]
    public override string DtdVersion { get; init; } = "1";

    [XmlAttribute]
    public override string DtdRelease { get; init; }  = "0";

    public XmlIntField? DocumentVersion { get; init; }

    public XmlStringField? DocumentType { get; init; }

    public XmlStringCodingField? SenderIdentification { get; init; }

    public XmlStringField? SenderRole { get; init; }

    public XmlStringCodingField? ReceiverIdentification { get; init; }

    public XmlStringField? ReceiverRole { get; init; }

    public XmlDateTimeField? CreationDateTime { get; init; }

    public XmlTimeIntervalField? RelatedTimeInterval { get; init; }

    public XmlStringField? ExpectedDocumentType { get; init; }

    public XmlDateTimeField? ExpectedDocumentDeadline { get; init; }

    public XmlStringField? ExpectedProcessType { get; init; }

    public XmlDateTimeField? ExpectedDeliveryDateTime { get; init; }

    public XmlStringCodingField? Domain { get; init; }

}
