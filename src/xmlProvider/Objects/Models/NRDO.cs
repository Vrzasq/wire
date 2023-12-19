namespace xmlObjectProvider.Objects.Models;

public record NRDO
{
    public string? NR { get; init; }

    public static implicit operator NRDO(string value) => new() { NR = value };
}
