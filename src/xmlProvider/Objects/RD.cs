using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record RD : TrescBase
{
    public string? NRR { get; init; }

    public string? NR { get; init; }

    public string? STR { get; init; }

    public RDEB? RDEB { get; init; }

    public RDMB? RDMB { get; init; }

    public RDRO? RDRO { get; init; }

    public RDEN? RDEN { get; init; }
}
