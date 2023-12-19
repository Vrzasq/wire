using System.Runtime.Intrinsics.Arm;
using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweEB : DaneIloscioweBase
{
    public decimal EZ { get; init; }

    public decimal ES { get; init; }

    public decimal ER { get; init; }

    public decimal E_BPP { get; init; }

    public decimal EB_FCR { get; init; }

    public decimal EB_aFRR { get; init; }

    public decimal EB_mFRRd { get; init; }

    public decimal dCEB { get; init; }

    public decimal? dKU { get; init; }

    [XmlIgnore]
    public bool dKUSpecified => dKU.HasValue;

    public decimal EO { get; init; }

    public decimal KEO { get; init; }

    public decimal NEB { get; init; }

    [XmlElement("CW")]
    public CW[]? CW { get; set; }

    [XmlElement("DPO")]
    public DPO[]? DPO { get; set; }

}
