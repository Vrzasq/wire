using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record OkresZgloszenia<TElement> where TElement : class
{
    public required Okres DT { get; init; }

    public string R { get; init; } = "PT15M";

    [XmlElement("T")]
    public required TElement[] T { get; init; }
}
