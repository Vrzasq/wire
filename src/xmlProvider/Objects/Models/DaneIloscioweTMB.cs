using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweTMB : DaneIloscioweBase
{
    [XmlElement("TMB")]
    public TMB[]? TMB { get; init; }
}

public record TMB
{
    public string? BT { get; init; }

    public decimal? CMBP { get; init; }

    [XmlIgnore]
    public bool CMBPSpecified => CMBP.HasValue;

    public decimal? CMBU { get; init; }

    [XmlIgnore]
    public bool CMBUSpecified => CMBU.HasValue;

    public decimal? CMBNO { get; init; }

    [XmlIgnore]
    public bool CMBNOSpecified => CMBNO.HasValue;

    public decimal? CMBNN { get; init; }

    [XmlIgnore]
    public bool CMBNNSpecified => CMBNN.HasValue;
}
