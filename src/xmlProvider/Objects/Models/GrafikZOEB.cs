namespace xmlObjectProvider.Objects.Models;

public record GrafikZOEB : GrafikBase<DaneIloscioweZOEB>
{
    public required string PT { get; init; }

    public string? D { get; init; }

    public string? KWS { get; init; }

    public string? KJB { get; init; }
}
