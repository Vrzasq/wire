namespace xmlObjectProvider.Objects.Models;

public record GrafikOBUS : GrafikBase<DaneIloscioweRHUS>
{
    public string? BT { get; init; }

    public string? KTP { get; init; }

    public string? NTP { get; init; }

    public string? JM { get; init; }
}
