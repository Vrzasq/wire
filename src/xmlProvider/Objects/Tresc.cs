using System.Xml.Serialization;
using xmlObjectProvider.Objects.generated.RHER;

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

    public PPE? PPE { get; init; }

    public RHER? RHER { get; init; }

    public RH? RH { get; init; }

    public RHK? RHK { get; init; }

    public RD? RD { get; init; }

    public RDEW? RDEW { get; init; }

    public RHUS? RHUS { get; init; }

    public RHUS? RHKUS { get; init; }

    [XmlElement(ElementName = "ScheduleMessage", Namespace = "schedule-xml.xsd")]
    public ZGWM? ScheduleMessage { get; init; }

    [XmlElement(ElementName = "AcknowledgementDocument", Namespace = "acknowledgement-xml.xsd")]
    public PGWM? PGWM { get; init; }

    [XmlElement(ElementName = "AcknowledgementDocument", Namespace = "acknowledgement.xsd")]
    public PKOR? PKOR { get; init; }

    [XmlElement(ElementName = "ProblemStatementDocument", Namespace = "epsd-xsd.xsd")]
    public KOR? KOR { get; init; }

    [XmlElement(ElementName = "AnomalyReport", Namespace = "anomaly-xml.xsd")]
    public IGWM? IGWM { get; init; }

    [XmlElement(ElementName = "ConfirmationReport", Namespace = "confirmation-xml.xsd")]
    public UGWM? UGWM { get; init; }

    public string? INFO { get; init; }
}
