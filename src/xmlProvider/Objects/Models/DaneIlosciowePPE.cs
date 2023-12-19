namespace xmlObjectProvider.Objects.Models;

public record DaneIlosciowePPE : DaneIloscioweBase
{
    public int WPPO { get; init; }

    public string? SPPO { get; init; }

    public int WPOD { get; init; }

    public string? SPOD { get; init; }
}
