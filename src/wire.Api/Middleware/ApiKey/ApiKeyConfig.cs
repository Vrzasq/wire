namespace wire.Api.Middleware.ApiKey;

public record ApiKeyConfig
{
    public const string SectionName = "ApiKey";

    public required string Key { get; init; }
}
