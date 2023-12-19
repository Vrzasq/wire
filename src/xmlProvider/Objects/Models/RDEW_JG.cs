using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record RDEW_JG
{
    public string? KDUB {  get; init; }

    public string? KJG {  get; init; }

    public EWEB? EWEB { get; init; }

    public EWMB? EWMB { get; init; }

    public EWRO? EWRO { get; init; }

    public PM? PM { get; init; }

    public CWM? CWM { get; init; }
}

public record EWEB
{
    public GrafikEWEB? TS { get; init; }
}

public record GrafikEWEB : GrafikBase<DaneIloscioweEB>
{
    public string? PT { get; init; }
}

public record EWMB
{
    [XmlElement("TS")]
    public GrafikEWMB[]? TS { get; set; }
}

public record GrafikEWMB : GrafikBase<DaneIloscioweMB>
{
    public string? PT { get; init; }

    public string? BT { get; init; }
}

public record EWRO
{
    public GrafikEWRO? TS { get; init; }
}

public record GrafikEWRO : GrafikBase<DaneIloscioweRO>
{
    public string? PT { get; set; }
}

public record PM
{
    public GrafikPM? TS { get; init; }
}

public record CWM
{
    public GrafikCWM? TS { get; init; }
}

