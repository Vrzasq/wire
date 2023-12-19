using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record RHEN
{
    [XmlElement("JB")]
    public JB[]? JB { get; set; }
}
