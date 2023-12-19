using System.Xml.Serialization;

namespace xmlObjectProvider.Objects;

[XmlType(AnonymousType = true, Namespace = "http://www.pse.pl/osp")]
[XmlRoot(Namespace = "http://www.pse.pl/osp", IsNullable = false)]
public record INFO
{
    [XmlText]
    public string? Value { get; set; }
}
