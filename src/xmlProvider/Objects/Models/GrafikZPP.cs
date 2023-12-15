namespace xmlObjectProvider.Objects.Models;

public record GrafikZPP : GrafikBase<DaneIloscioweZPP>
{
    public required string PT { get; init; }

    public string? BT { get; init; }

    public string? KWS { get; init; }
}
