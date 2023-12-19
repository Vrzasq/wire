namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweEN : DaneIloscioweBase
{
    public decimal PB { get; init; }

    public decimal PW { get; init; }

    public decimal KN { get; init; }

    public decimal EN { get; init; }

    public decimal NEN { get; init; }
}
