using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweZUSE_ZUSEB
{
    public required int P { get; init; }

    public required decimal Q { get; init; }

    [XmlElement("K")]
    public KomunikatWeryfikacji[]? K { get; init; }
}
