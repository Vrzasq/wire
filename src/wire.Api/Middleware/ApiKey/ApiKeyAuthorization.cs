using Microsoft.Extensions.Primitives;

namespace wire.Api.Middleware.ApiKey;

public class ApiKeyAuthorization(
    RequestDelegate next,
    IApiKeyValidator apiKeyValidator)
{
    public const string ApiKeyHeader = "x-api-key";

    public async Task InvokeAsync(HttpContext context)
    {
        var apiKeyHeader = context.Request.Headers[ApiKeyHeader];

        if (apiKeyHeader == StringValues.Empty)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            return;
        }

        if (!apiKeyValidator.IsValid(apiKeyHeader))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return;
        }

        await next(context);
    }
}