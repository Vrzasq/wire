using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

[Serializable]
[XmlType(Namespace = "etso-core-cmpts.xsd")]
public record class XmlIntField
{
    [XmlAttribute(AttributeName = "v")]
    public required int V { get; init; }

    public override string ToString() => V.ToString();

    public static implicit operator int(XmlIntField self) => self.V;
    public static implicit operator XmlIntField(int i) => new() { V = i };
}