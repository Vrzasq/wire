using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

[Serializable]
[XmlType(Namespace = "etso-core-cmpts.xsd")]
public record class XmlStringField
{
    [XmlAttribute(AttributeName = "v")]
    public required string V { get; init; }

    public override string ToString() => V;

    public static implicit operator string(XmlStringField self) => self.V;
    public static implicit operator XmlStringField(string s) => new() { V = s };
}