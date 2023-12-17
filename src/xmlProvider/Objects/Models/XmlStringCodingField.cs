using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record class XmlStringCodingField() : XmlStringField
{
    [SetsRequiredMembers]
    public XmlStringCodingField(
        string value,
        string codingScheme) : this()
    {
        V = value;
        CodingScheme = codingScheme;
    }

    [XmlAttribute(AttributeName = "codingScheme")]
    public required string CodingScheme { get; init; }

    public override string ToString() =>
        $"{nameof(V)} = {V} {nameof(CodingScheme)} = {CodingScheme}";

    public static implicit operator XmlStringCodingField((string value, string codingScheme) value) => new(value.value, value.codingScheme);
}
