namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweZOMB : DaneIloscioweBase
{
    public required int PMAX { get; init; }

    public required int PMIN { get; init; }

    public required int PLMAX { get; init; }

    public required int PLMIN { get; init; }

    public required decimal OFC { get; init; }
}
