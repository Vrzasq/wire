namespace xmlObjectProvider.Objects.Models;

public record EBPM
{
    public string? MT { get; init; }

    public string? OREB { get; init; }

    public decimal EB { get; init; }

    public decimal CWK { get; init; }

    public decimal CRK { get; init; }
}
