using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record ENJ
{
    public string? RR { get; init; }

    public decimal ENDE { get; init; }

    public decimal ENOE { get; init; }

    public decimal? CENDE { get; init; }

    [XmlIgnore]
    public bool CENDESpecified => CENDE.HasValue;

    public decimal? CENOE { get; init; }

    [XmlIgnore]
    public bool CENOESpecified => CENOE.HasValue;

    public decimal NENDE { get; init; }

    public decimal NENOE { get; init; }
}
