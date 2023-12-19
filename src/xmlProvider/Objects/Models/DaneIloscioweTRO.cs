using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweTRO : DaneIloscioweBase
{
    public TRO? TRO { get; init; }
}

public record TRO
{
    public decimal COR { get; init; }

    public decimal? COR_RR { get; init; }

    [XmlIgnore]
    public bool COR_RRSpecified => COR_RR.HasValue;
}
