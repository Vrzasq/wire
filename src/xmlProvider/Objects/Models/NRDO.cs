namespace xmlObjectProvider.Objects.Models;

public record NRDO
{
    public string? NR { get; init; }

    public string? NRP { get; init; }

    public static implicit operator NRDO((string? nr, string? nrp) value) => new() { NR = value.nr, NRP = value.nrp };
}
