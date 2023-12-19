namespace xmlObjectProvider.Objects.Models;

public record DaneIloscioweTEN : DaneIloscioweBase
{
    public TEN? TEN { get; init; }
}

public record TEN
{
    public decimal CEN { get; init; }

    public decimal CEB_SR { get; init; }

    public decimal CSDAC { get; init; }

    public decimal SK { get; init; }
}
