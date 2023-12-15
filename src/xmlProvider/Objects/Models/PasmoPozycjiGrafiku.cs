using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record PasmoPozycjiGrafiku
{
    public required int NP { get; init; }

    public required decimal OFP { get; init; }

    public required decimal OFCG { get; init; }

    public required decimal OFCD { get; init; }

    [XmlElement("K")]
    public KomunikatWeryfikacji[]? K { get; init; }
}
