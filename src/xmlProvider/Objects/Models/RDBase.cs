using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public abstract record RDBase<TElement, TGrafikElement>
    where TElement : JGElementBase
    where TGrafikElement : class
{
    [XmlElement("JG")]
    public TElement[]? JG { get; init; }

    public GrafikBase<TGrafikElement>? TS { get; init; }
}
