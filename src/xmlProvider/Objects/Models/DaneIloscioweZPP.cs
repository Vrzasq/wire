namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweZPP : DaneIloscioweBase
{
    /// <summary>
    /// decimal
    /// </summary>
    public string? POBC { get; init; }

    public string? SO { get; init; }

    public string? ZUB { get; init; }

    public string? ZWP { get; init; }

    /// <summary>
    /// decimal
    /// </summary>
    public string? NZSN { get; init; }

    /// <summary>
    /// decimal
    /// </summary>
    public string? PD { get; init; }

    /// <summary>
    /// decimal
    /// </summary>
    public string? PO { get; init; }

    public string? ZPDO { get; init; }

    public string? PMB { get; init; }

    public string? ZZGMB { get; init; }
}
