namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweFDMB : DaneIloscioweBase
{
    public required int WPPO { get; init; }

    public required string SPPO { get; init; }

    public required int WPOD { get; init; }

    public required string SPOD { get; init; }
}
