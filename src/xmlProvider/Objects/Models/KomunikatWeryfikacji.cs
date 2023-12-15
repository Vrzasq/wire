using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

[XmlType(Namespace = "http://www.pse.pl/osp")]
[Serializable]
public record class KomunikatWeryfikacji
{
    public string? TK { get; init; }
}
