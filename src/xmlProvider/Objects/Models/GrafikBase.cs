using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

[XmlType(Namespace = "http://www.pse.pl/osp")]
[Serializable]
public abstract record GrafikBase<TElement> where TElement : class
{
    public required string mRID { get; init; }

    public OkresZgloszenia<TElement>? TSP { get; init; }

    [XmlElement("K")]
    public KomunikatWeryfikacji[]? K { get; init; }

    public string? VS { get; init; }
}
