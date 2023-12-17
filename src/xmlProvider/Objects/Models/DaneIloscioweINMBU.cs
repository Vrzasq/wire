namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweINMBU : DaneIloscioweBase
{
    public string? MBU { get; init; }

    public string? MBZ { get; init; }

    public string? MZW { get; init; }

    public string? MBO { get; init; }
}
