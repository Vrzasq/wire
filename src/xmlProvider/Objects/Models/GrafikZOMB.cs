namespace xmlObjectProvider.Objects.Models;

public record GrafikZOMB : GrafikBase<DaneIloscioweZOMB>
{
    public required string BT { get; init; }
}
