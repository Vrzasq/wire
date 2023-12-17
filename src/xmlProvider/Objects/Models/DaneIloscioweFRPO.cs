namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweFRPO : DaneIloscioweBase
{
    public required int WAPO { get; init; }

    public required string STPO { get; init; }
}
