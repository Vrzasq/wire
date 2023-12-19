namespace xmlObjectProvider.Objects.Models;

public record RDEN : RHEN
{
    public GrafikRDEN? TS { get; init; }
}

public record GrafikRDEN : GrafikBase<DaneIloscioweTEN> { }
