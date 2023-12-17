namespace xmlObjectProvider.Objects.Models;

public record GrafikINMBU : GrafikBase<DaneIloscioweINMBU>
{
    public string? BT { get; init; }

    public string? CT { get; init; }
}
