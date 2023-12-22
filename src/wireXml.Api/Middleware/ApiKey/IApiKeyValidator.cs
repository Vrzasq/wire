namespace wireXml.Api.Middleware.ApiKey;

public interface IApiKeyValidator
{
    bool IsValid(string? apiKey);
}
