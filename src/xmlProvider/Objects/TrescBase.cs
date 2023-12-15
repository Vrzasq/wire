using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public abstract record TrescBase
{
    public required string mRID { get; init; }

    public required int W { get; init; }

    public required string KO { get; init; }

    public string? IDOT { get; init; }

    public string? IIW { get; init; }

    public string? rmRID { get; init; }

    public string? VS { get; init; }

    public required Okres DT { get; init; }

    public Okres? VDT { get; init; }

    [XmlElement("K")]
    public KomunikatWeryfikacji[]? K { get; init; }
}
