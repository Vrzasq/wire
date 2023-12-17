using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record INMBU : TrescBase
{
    [XmlElement("TSJ")]
    public DaneIdentyfikacyjneJG[]? TSJ { get; set; }
}
