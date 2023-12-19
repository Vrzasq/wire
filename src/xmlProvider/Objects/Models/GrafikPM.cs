using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record GrafikPM
{
    public string? PT { get; init; }

    public OkresPM? TSP { get; init; }
}

public record OkresPM
{
    public Okres? DT { get; init; }

    public string? R { get; init; }

    public DaneIlosciowePM? T { get; init; }
}

public record DaneIlosciowePM : DaneIloscioweBase
{
    [XmlElement("PPM")]
    public PPM[]? PPM { get; set; }
}

public record PPM
{
    public int NPM { get; init; }

    public decimal PMIN { get; init; }

    public decimal PMAX { get; init; }
}
