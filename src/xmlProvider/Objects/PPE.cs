using System.Xml.Serialization;
using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record PPE : TrescBase
{
    public string? KPPE { get; init; }

    public DateTime? DTS { get; init; }

    [XmlIgnore]
    public bool DTSSpecified => DTS.HasValue;

    public DateTime? DTK { get; set; }

    [XmlIgnore]
    public bool DTKSpecified => DTK.HasValue;

    public GrafikPPE? TS { get; set; }
}