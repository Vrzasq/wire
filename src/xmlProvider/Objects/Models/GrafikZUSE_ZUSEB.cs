using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

[XmlType(Namespace = "http://www.pse.pl/osp")]
[Serializable]
public record GrafikZUSE_ZUSEB : GrafikBase<DaneIloscioweZUSE_ZUSEB>
{
    public required string KJB { get; init; }

    public required string KO { get; init; }
}
