using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DPO
{
    public int NP { get; init; }

    public string? ZP { get; init; }

    public string? D { get; init; }

    public decimal OFCG { get; init; }

    public decimal OFCD { get; init; }

    public decimal CDO { get; init; }

    public decimal OFP { get; init; }

    public decimal KEB { get; init; }

    [XmlElement("EBPM")]
    public EBPM[]? EBPM { get; init; }
}
