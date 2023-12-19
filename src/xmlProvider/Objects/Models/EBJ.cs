using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record EBJ
{
    public string? RR { get; init; }

    public decimal EBDE { get; init; }

    public decimal EBOE { get; init; }

    public decimal? CEBDE { get; init; }

    [XmlIgnore]
    public bool CEBDESpecified => CEBDE.HasValue;

    public decimal? CEBOE { get; init; }

    [XmlIgnore]
    public bool CEBOESpecified => CEBOE.HasValue;

    public decimal NEBDE { get; init; }

    public decimal NEBOE { get; init; }
}
