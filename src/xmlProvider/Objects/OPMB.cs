using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record OPMB : TrescBase
{
    public required string KDUB { get; init; }

    [XmlElement("BID")]
    public required OfertaZOPMB[]? BID { get; init; }
}
