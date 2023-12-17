namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweFRP : DaneIloscioweBase
{
    public required int WAPO { get; init; }

    public required string STPO { get; init; }
}
