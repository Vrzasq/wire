using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record ScheduleTime
{
    public XmlStringField? ImposedTimeSeriesIdentification { get; init; }

    public XmlStringCodingField? MessageSenderIdentification { get; init; }

    public XmlStringField? SendersMessageIdentification { get; init; }

    public XmlIntField? SendersMessageVersion { get; init; }

    public XmlIntField? ImposedTimeSeriesVersion { get; init; }

    public XmlStringField? SendersTimeSeriesIdentification { get; init; }

    public XmlIntField? SendersTimeSeriesVersion { get; init; }

    public XmlStringField? BusinessType { get; init; }

    public XmlStringField? Product { get; init; }

    public XmlStringField? ObjectAggregation { get; init; }

    public XmlStringCodingField? InArea { get; init; }

    public XmlStringCodingField? OutArea { get; init; }

    public XmlStringCodingField? MeteringPointIdentification { get; init; }

    public XmlStringCodingField? InParty { get; init; }

    public XmlStringCodingField? OutParty { get; init; }

    public XmlStringField? CapacityContractType { get; init; }

    public XmlStringField? CapacityAgreementIdentification { get; init; }

    public XmlStringField? MeasurementUnit { get; init; }

    public Period? Period { get; init; }

    [XmlElement("Reason")]
    public Reason[]? Reason { get; init; }
}
