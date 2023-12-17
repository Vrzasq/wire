namespace xmlObjectProvider.Objects.Models;

public record Reason
{
    public required XmlStringField ReasonCode { get; init; }

    public XmlStringField? ReasonText { get; init; }
}
