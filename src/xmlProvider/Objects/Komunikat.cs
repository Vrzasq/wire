using System.Diagnostics;
using System.Xml.Serialization;

namespace xmlObjectProvider.Objects;

[DebuggerStepThrough]
[XmlType(AnonymousType = true, Namespace = "http://www.pse.pl/osp")]
[XmlRoot(Namespace = "http://www.pse.pl/osp", IsNullable = false)]
[Serializable]
public record Komunikat
{
    public required Naglowek Naglowek { get; init; }

    public required Tresc? Tresc { get; init; }
}