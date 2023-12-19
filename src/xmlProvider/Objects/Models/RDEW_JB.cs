namespace xmlObjectProvider.Objects.Models;

public record RDEW_JB
{
    public string? KPOB { get; init; }

    public string? KJB { get; init; }

    public EWEN? EWEN { get; init; }
}

public record EWEN : GrafikBase<DaneIloscioweEN>
{
    public GrafikEWEN? TS { get; init; }
}

public record GrafikEWEN : GrafikBase<DaneIloscioweEN>
{
    public string? PT { get; init; }
}