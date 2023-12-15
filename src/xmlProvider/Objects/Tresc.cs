namespace xmlObjectProvider.Objects;

public record Tresc
{
    /// <summary>
    /// Umowa sprzedaży energii dnia następnego
    /// </summary>
    public ZUSE_ZUSEB? USE { get; init; }

    /// <summary>
    /// Umowa sprzedaży energii dnia bierzącego
    /// </summary>
    public ZUSE_ZUSEB? USEB { get; init; }

    /// <summary>
    /// Oferta portfolio na moce bilansujące
    /// </summary>
    public ZOPMB? OPMB { get; init; }

    /// <summary>
    /// Program pracy
    /// </summary>
    public ZPP? PP { get; init; }

    /// <summary>
    /// Oferty na energię bilansującą
    /// </summary>
    public ZOEB? OEB { get; init; }

    /// <summary>
    /// Oferty techniczne
    /// </summary>
    public ZOT? OT { get; init; }

    /// <summary>
    /// Oferty na moce bilansujace
    /// </summary>
    public ZOMB? OMB { get; init; }
}
