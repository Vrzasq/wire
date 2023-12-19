using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record MBJ
{
    public string? RR { get; init; }

    public string? BT { get; init; }

    public decimal MBPUE { get; init; }

    public decimal? CMBPUE { get; init; }

    [XmlIgnore]
    public bool CMBPUESpecified => CMBPUE.HasValue;

    public decimal NMBPUE { get; init; }
}
