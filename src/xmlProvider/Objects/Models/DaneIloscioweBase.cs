using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public abstract record DaneIloscioweBase
{
    public required int P { get; init; }

    [XmlElement("K")]
    public KomunikatWeryfikacji[]? K { get; init; }
}
