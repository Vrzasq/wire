using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweRHUS
{
    public string? RR { get; init; }

    public decimal? Q { get; init; }

    [XmlIgnore]
    public bool QSpecified => Q.HasValue;

    public decimal? CUS { get; init; }

    [XmlIgnore]
    public bool CUSSpecified => CUS.HasValue;

    public decimal? NUS { get; init; }

    [XmlIgnore]
    public bool NUSSpecified => NUS.HasValue;
}

