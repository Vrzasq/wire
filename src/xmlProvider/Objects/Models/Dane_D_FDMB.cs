using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record Dane_D_FDMB
{
    public Okres? DT { get; init; }

    public string? R { get; init; }

    [XmlElement("TPOOD")]
    public TPOOD[]? TPOOD { get; init; }
}
