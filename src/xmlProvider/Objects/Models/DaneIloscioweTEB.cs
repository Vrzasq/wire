using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweTEB : DaneIloscioweBase
{
    public TEB? TEB { get; init; }
}

public record TEB
{
    public decimal CEB_PP { get; init; }

    public decimal? CEB_RR { get; init; }

    [XmlIgnore]
    public bool CEB_RRSpecified => CEB_RR.HasValue;

    public decimal CSDAC { get; init; }

    public decimal CKOEB { get; init; }

    public decimal CEO { get; init; }
}
