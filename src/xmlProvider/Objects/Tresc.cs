using System.Xml.Serialization;

namespace xmlObjectProvider.Objects;

public record Tresc
{
    /// <summary>
    /// Umowa sprzedaży energii dnia następnego
    /// </summary>
    public USE_USEB? USE { get; init; }

    /// <summary>
    /// Umowa sprzedaży energii dnia bierzącego
    /// </summary>
    public USE_USEB? USEB { get; init; }

    /// <summary>
    /// Oferta portfolio na moce bilansujące
    /// </summary>
    public OPMB? OPMB { get; init; }

    /// <summary>
    /// Program pracy
    /// </summary>
    public PP? PP { get; init; }

    /// <summary>
    /// Oferty na energię bilansującą
    /// </summary>
    public OEB? OEB { get; init; }

    /// <summary>
    /// Oferty techniczne
    /// </summary>
    public OT? OT { get; init; }

    /// <summary>
    /// Oferty na moce bilansujace
    /// </summary>
    public OMB? OMB { get; init; }

    public INMBP? INMBP { get; init; }

    public INMBU? INMBU { get; init; }

    public IAEBRR? IAEBRR { get; init; }

    public FRP? FRP { get; init; }

    public FRPO? FRPO { get; init; }

    public FDMB? FDMB { get; init; }

    [XmlElement(Namespace = "schedule-xml.xsd")]
    public ZGWM? ScheduleMessage { get; init; }

    [XmlElement(Namespace = "acknowledgement-xml.xsd")]
    public PGWM? AcknowledgementDocument { get; init; }

    [XmlElement(Namespace = "anomaly-xml.xsd")]
    public IGWM? AnomalyReport { get; init; }

    [XmlElement(Namespace = "confirmation-xml.xsd")]
    public UGWM? ConfirmationReport { get; init; }
}
