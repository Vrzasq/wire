namespace xmlObjectProvider.Objects.Models;

public record GrafikZOT : GrafikBase<DaneIloscioweZOT>
{
    public string? SU { get; init; }

    public int TTP { get; init; }

    public int TTS { get; init; }

    public int TTR{ get; init; }
}
