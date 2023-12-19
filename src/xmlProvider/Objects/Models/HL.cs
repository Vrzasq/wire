namespace xmlObjectProvider.Objects.Models;

public record HL
{
    public int L { get; init; }

    public ALG? ALG { get; init; }

    public PPOM? PPOM { get; init; }

    public RFRP? RFRP { get; init; }

    public D_FRP? FRP { get; init; }
}
