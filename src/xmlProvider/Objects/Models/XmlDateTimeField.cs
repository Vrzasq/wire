using System.Xml.Serialization;
using static xmlObjectProvider.Objects.Models.DateTimeFormats;

namespace xmlObjectProvider.Objects.Models;

[Serializable]
[XmlType(Namespace = "etso-core-cmpts.xsd")]
public record class XmlDateTimeField
{
    private DateTime? _dt;
    private string? _v;

    [XmlIgnore]
    public required DateTime DT
    {
        get
        {
            if (_dt.HasValue)
                return _dt.Value;

            _dt = DateTime.Parse(V).ToUniversalTime();

            return _dt.Value;
        }

        init => _dt = value;
    }

    [XmlAttribute(AttributeName = "v")]
    public string V
    {
        get
        {
            if (!string.IsNullOrEmpty(_v))
                return _v;

            _v = DT.ToString(XmlFormat);

            return _v;
        }

        init => _v = value;
    }

    public override string ToString() =>
        DT.ToString();

    public static implicit operator DateTime(XmlDateTimeField self) => self.DT;
    public static implicit operator XmlDateTimeField(DateTime dateTime) => new() { DT = dateTime };
}
