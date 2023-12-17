namespace xmlObjectProvider.Objects.Models;

public record LFRP
{
    public required string KFRP { get; init; }

    public string? Z { get; init; }

    public string? TN { get; init; }

    public string? TK { get; init; }

    public string? PKFRP { get; init; }
}
