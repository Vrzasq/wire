using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public abstract record RHBase<TElement> where TElement : JGElementBase
{
    [XmlElement("JG")]
    public TElement[]? JG { get; init; }
}
