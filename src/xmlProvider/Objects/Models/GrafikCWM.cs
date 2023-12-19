namespace xmlObjectProvider.Objects.Models;

public record GrafikCWM
{
    public string? PT { get; init; }

    public OkresCWM? TSP { get; init; }
}

public record OkresCWM
{
    public Okres? DT { get; init; }

    public string? R { get; init; }

    public DaneIloscioweCWM? T { get; init; }
}

public record DaneIloscioweCWM : DaneIloscioweBase
{
    public decimal CWDL {  get; init; }

    public decimal CWOL {  get; init; }

    public decimal CWDG {  get; init; }

    public decimal CWOG {  get; init; }
}