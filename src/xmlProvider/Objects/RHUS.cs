using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record RHUS : TrescBase
{
    public string? NRR { get; init; }

    public string? KPB { get; init; }

    public string? KUM { get; init; }

    public string? NR { get; init; }

    public string? STR { get; init; }

    public string? NRP { get; init; }

    [XmlArrayItem("NRD", IsNullable = false)]
    public NRDO[]? NRDO { get; init; }

    [XmlElement("OBUS")]
    public OBUS[]? OBUS { get; init; }

    public PUS? PUS { get; init; }
}

public record OBUS
{
    public string? KOB {  get; init; }

    public string? NOB {  get; init; }

    [XmlElement("TS")]
    public GrafikOBUS[]? TS { get; init; }
}

public record PUS
{
    public string? KPB { get; init; }

    [XmlElement("TS")]
    public GrafikOBUS[]? TS { get; init; }
}