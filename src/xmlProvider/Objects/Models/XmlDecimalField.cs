using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

[Serializable]
[XmlType(Namespace = "etso-core-cmpts.xsd")]
public record class XmlDecimalField
{
    [XmlAttribute(AttributeName = "v")]
    public required decimal V { get; init; }

    public override string ToString() => V.ToString();

    public static implicit operator decimal(XmlDecimalField self) => self.V;
    public static implicit operator XmlDecimalField(decimal i) => new() { V = i };
}