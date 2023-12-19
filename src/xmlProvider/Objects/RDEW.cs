using xmlObjectProvider.Objects.Models;

namespace xmlObjectProvider.Objects;

public record RDEW : TrescBase
{
    public string? NRR { get; init; }

    public string? NR { get; init; }

    public string? STR { get; init; }

    public RDEW_JG? JG { get; init; }

    public RDEW_JB? JB { get; init; }
}
