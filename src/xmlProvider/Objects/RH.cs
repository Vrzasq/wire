using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record RH : TrescBase
{
    public string? NRR { get; init; }

    public string? NR { get; init; }

    public string? STR { get; init; }

    [XmlArrayItem("NRD", IsNullable = false)]
    public NRDO[]? NRDO { get; init; }

    public RHEB? RHEB { get; init; }

    public RHMB? RHMB { get; init; }

    public RHRO? RHRO { get; init; }

    public RHEN? RHEN { get; init; }
}
