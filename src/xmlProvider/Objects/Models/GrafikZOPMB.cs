namespace xmlObjectProvider.Objects.Models;

public record GrafikZOPMB : GrafikBase<DaneIloscioweZOPMB>
{
    public required string BT {  get; init; }
}
