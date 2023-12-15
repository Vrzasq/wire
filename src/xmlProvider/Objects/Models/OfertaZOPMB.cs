using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record OfertaZOPMB
{
    public required int BN { get; init; }

    public string? VS { get; init; }

    [XmlElement("K")]
    public KomunikatWeryfikacji[]? K { get; init; }

    public required GrafikZOPMB[] TS {  get; init; }
}
