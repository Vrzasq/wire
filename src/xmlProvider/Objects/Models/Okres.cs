namespace xmlObjectProvider.Objects.Models;

public record Okres
{
    public required DateTime DTS { get; init; }
    public required DateTime DTK { get; init; }
}
