using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweMB : DaneIloscioweBase
{
    public decimal MBP { get; init; }

    public decimal MBPZ { get; init; }

    public decimal MBU { get; init; }

    public decimal MBUZ { get; init; }

    public decimal MBD { get; init; }

    public decimal MBNO { get; init; }

    public decimal MBNN { get; init; }

    public decimal MBNNO { get; init; }

    public decimal? CMBZ { get; init; }

    [XmlIgnore]
    public bool CMBZSpecified => CMBZ.HasValue;

    public decimal NMBPU { get; init; }
}
