namespace xmlObjectProvider.Objects.Models;

public record Okres
{
    public required DateTime DTS { get; init; }
    public required DateTime DTK { get; init; }

    public static implicit operator Okres((DateTime dts, DateTime dtk) okres) => new() { DTS = okres.dts, DTK = okres.dtk };
}
