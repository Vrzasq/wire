namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweZOPMB : DaneIloscioweBase
{
    public required int POM { get; init; }

    public required decimal COM { get; init; }

    public required decimal COMRR { get; init; }
}
