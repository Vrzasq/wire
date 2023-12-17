namespace xmlObjectProvider.Objects.Models;

public record Interval
{
    public required XmlIntField Pos { get; init; }

    public required XmlDecimalField Qty { get; init; }
}
