using Microsoft.Extensions.Options;

namespace wireXml.Api.Middleware.ApiKey;

public class ApiKeyValidator(
    IOptions<ApiKeyConfig> config) : IApiKeyValidator
{
    private readonly ApiKeyConfig _config = config.Value;

    public bool IsValid(string? apiKey)
    {
        if (apiKey != _config.Key)
            return false;

        return true;
    }
}
