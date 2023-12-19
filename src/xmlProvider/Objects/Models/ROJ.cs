using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record ROJ
{
    public string? RR { get; init; }

    public decimal RORE { get; init; }

    public decimal? CORE { get; init; }

    [XmlIgnore]
    public bool CORESpecified => CORE.HasValue;

    public decimal NROE { get; init; }
}
