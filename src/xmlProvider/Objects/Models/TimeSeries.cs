using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record TimeSeries
{
    public XmlStringField? SendersTimeSeriesIdentification { get; init; }

    public XmlIntField? SendersTimeSeriesVersion { get; init; }

    [XmlElement("TimeIntervalError")]
    public TimeInterval[]? TimeIntervalError { get; init; }

    [XmlElement("Reason")]
    public Reason[]? Reason { get; init; }
}
